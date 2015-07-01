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

        public ActionResult Index(int episodeId)
        {
            var episode = context.Episodes.First(e => e.EpisodeId.Equals(episodeId));

            return View(episode);
        }

        public ActionResult Encounter(int encounterId = -1)
        {
            if (!context.Encounters.Any())
            {
                return View(CreateDefaultEncounter());
            }

            if (encounterId == -1) // No specified id
            {
                return View(context.Encounters.First());
            }

            return View(context.Encounters.First(e => e.EncounterId.Equals(encounterId)));
        }

        [HttpGet]
        public PartialViewResult Add(int episodeId)
        {
            var episode = context.Episodes.First(c => c.EpisodeId.Equals(episodeId));

            return PartialView(episode);
        }

        [HttpPut]
        public JsonResult Add(int episodeId, string name, string description, string summary)
        {
            var episode = context.Episodes.First(c => c.EpisodeId.Equals(episodeId));

            episode.Encounters.Add(new Encounter()
            {
                Name = name,
                Description = description,
                BattleMapImage = "",
                Order = episode.Encounters.Count(),
                Initiatives = new List<Initiative>()
                {
                    new Initiative()
                    {
                        Character = context.Characters.Single(m => m.Name.Equals("Dungeon Master")),
                        TurnOrder = 0
                    }
                }
            });

            context.SaveChanges();

            return Json("Yes");
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
