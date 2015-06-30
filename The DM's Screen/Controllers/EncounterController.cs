using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using TheDmScreen.Models;

namespace TheDmScreen.Controllers
{
    public class EncounterController : Controller
    {
        private readonly DmScreenContext context;

        public EncounterController()
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
