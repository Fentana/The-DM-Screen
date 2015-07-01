using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        [HttpGet]
        public PartialViewResult Edit(int encounterId)
        {
            var initiatives = context.Encounters.First(e => e.EncounterId.Equals(encounterId)).Initiatives.ToList();

            return PartialView(initiatives);
        }

        [HttpGet]
        public JsonResult Autocomplete(int encounterId, string term)
        {
            var uniquePlayers = context.Campaigns.First(
                e => e.Episodes.Any(f => f.Encounters.Any(g => g.EncounterId.Equals(encounterId)))).Characters;
            var nonuniquePlayers = context.Characters.Where(c => !c.IsUnique);

            var results = uniquePlayers.Concat(nonuniquePlayers);

            return Json(results.Where(
                item => item.Name.IndexOf(term,
                    StringComparison.InvariantCultureIgnoreCase) >= 0), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public PartialViewResult Add(int encounterId)
        {
            var encounter = context.Encounters.First(e => e.EncounterId.Equals(encounterId));

            return PartialView(encounter);
        }

        [HttpPost]
        public JsonResult Add(int encounterId, int characterId, int roll)
        {
            var encounter = context.Encounters.First(e => e.EncounterId.Equals(encounterId));
            var character = context.Characters.First(e => e.CharacterId.Equals(characterId));

            encounter.Initiatives.Add(new Initiative()
            {
                Character = character,
                Roll = roll,
                TurnOrder = encounter.Initiatives.Count()
            });

            context.SaveChanges();
            return Json("We did it!");
        }

        [HttpPut]
        public JsonResult Delete(int encounterId, int characterId)
        {
            var encounter = context.Encounters.First(e => e.EncounterId.Equals(encounterId));
            var initiative = encounter.Initiatives.First(e => e.Character.CharacterId.Equals(characterId));

            encounter.Initiatives.Remove(initiative);

            if (!encounter.Initiatives.Any())
            {
                var dm = context.Characters.First(c => c.Name.Equals("Dungeon Master"));
                encounter.Initiatives.Add( new Initiative()
                {
                    Character = dm,
                    Roll = 20,
                    TurnOrder = 0
                });
            }

            context.SaveChanges();
            return Json("We did it!");
        }

        [HttpPut]
        public JsonResult Update(int encounterId, List<int> newOrder)
        {
            var newInitiatives = new List<Initiative>();
            var encounter = context.Encounters.First(e => e.EncounterId.Equals(encounterId));

            var newInit = from i in newOrder
                join initiative in encounter.Initiatives
                    on i equals initiative.Character.CharacterId
                select initiative;

            encounter.Initiatives = newInit.ToList();

            context.SaveChanges();

            return Json("Yay");
        }

        [HttpPost]
        public JsonResult GetName(int characterId)
        {
            return Json(context.Characters.First(c => c.CharacterId.Equals(characterId)).Name);
        }
    }
}
