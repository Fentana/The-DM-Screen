using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using TheDmScreen.Models;

namespace TheDmScreen.Controllers
{
    public class InitiativeController : Controller
    {
        private readonly DmScreenContext context;

        public InitiativeController()
        {
            context = new DmScreenContext();
        }

        public ActionResult Encounter(int id = -1)
        {
            if (!context.Encounters.Any())
            {
                return View(CreateDefaultEncounter());
            }

            if (id == -1) // No specified id
            {
                return View(context.Encounters.First());
            }
            
            return View(context.Encounters.First(e => e.EncounterId.Equals(id)));
        }

        [HttpPost]
        public JsonResult CommitTurn(int encounterId, string description)
        {
            var encounter = context.Encounters.First(e => e.EncounterId.Equals(encounterId));
            var actingCharacter = encounter.Initiatives.OrderBy(p => p.TurnOrder).First().Character;

            var feedEntry = new EncounterFeedEntry
            {
                ActingCharacter = actingCharacter,
                Description = description
            };
            context.Actions.Add(feedEntry);

            // Rotate the Turn Order
            RotateInitiatives(encounter, actingCharacter);

            encounter.FeedEntries.Add(feedEntry);
            context.SaveChanges();

            return Json("Successfully posted");
        }

        private static void RotateInitiatives(Encounter encounter, Character actingCharacter)
        {
            foreach (var init in encounter.Initiatives)
            {
                if (init.Character.Equals(actingCharacter))
                {
                    init.TurnOrder = encounter.Initiatives.Count - 1;
                    continue;
                }

                init.TurnOrder--;
            }
        }

        // Default Encounter just for the hell of it
        private Encounter CreateDefaultEncounter()
        {
            var desiredEncounter = new Encounter
            {
                BattleMapImage = "",
                FeedEntries = new List<EncounterFeedEntry>(),
                Initiatives = new List<Initiative>()
                {
                    new Initiative
                    {
                        Character = context.Characters.Single(m => m.Name.Equals("Dungeon Master")),
                        TurnOrder = 0
                    }                   
                }
            };

            context.Encounters.Add(desiredEncounter);
            context.SaveChanges();
            return desiredEncounter;
        }
    }
}
