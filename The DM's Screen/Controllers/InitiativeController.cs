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
        private readonly EncounterFeedContext context;

        public InitiativeController()
        {
            context = new EncounterFeedContext();
        }
        public ActionResult Encounter(int id = -1)
        {
            Encounter desiredEncounter;

            if (!context.Encounters.Any())
            {
                desiredEncounter = new Encounter
                {
                    BattleMapImage = "",
                    FeedEntries = new List<EncounterFeedEntry>()
                    {
                        
                    },
                    Participants = new List<Character>()
                    {
                        context.Characters.Single(m => m.Name.Equals("Ellywick")),
                        context.Characters.Single(m => m.Name.Equals("Hellbaby")),
                        context.Characters.Single(m => m.Name.Equals("Steelbeard")),
                        context.Characters.Single(m => m.Name.Equals("Trickfoot"))
                    }
                };

                context.Encounters.Add(desiredEncounter);
                context.SaveChanges();
            }
            else
            {
                if (id == -1)
                {
                    desiredEncounter = context.Encounters.First();
                }
                else desiredEncounter = context.Encounters.First(e => e.EncounterId.Equals(id));

                desiredEncounter.FeedEntries = new List<EncounterFeedEntry>();
            }

            return View(desiredEncounter);
        }
    }
}
