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
        private readonly DmScreenContext _context;

        public InitiativeController()
        {
            _context = new DmScreenContext();
        }

        [HttpGet]
        public JsonResult Autocomplete(int encounterId, string term)
        {
            var uniquePlayers = _context.Campaigns.First(
                e => e.Episodes.Any(f => f.Encounters.Any(g => g.Id.Equals(encounterId)))).Characters;
            var nonuniquePlayers = _context.Characters.Where(c => !c.IsUnique);

            var results = uniquePlayers.Concat(nonuniquePlayers);

            return Json(results.Where(
                item => item.Name.IndexOf(term,
                    StringComparison.InvariantCultureIgnoreCase) >= 0), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public PartialViewResult Add(int encounterId)
        {
            var encounter = _context.Encounters.First(e => e.Id.Equals(encounterId));

            return PartialView(encounter);
        }

        [HttpPost]
        public JsonResult Add(int encounterId, int characterId, int roll)
        {
            var encounter = _context.Encounters.First(e => e.Id.Equals(encounterId));
            var character = _context.Characters.First(e => e.Id.Equals(characterId));

            encounter.Initiatives.Add(new Initiative()
            {
                Character = character,
                Roll = roll,
                TurnOrder = encounter.Initiatives.Count()
            });

            _context.SaveChanges();
            return Json("We did it!");
        }

        [HttpPut]
        public JsonResult Delete(int encounterId, int characterId)
        {
            var encounter = _context.Encounters.First(e => e.Id.Equals(encounterId));
            var initiative = encounter.Initiatives.First(e => e.Character.Id.Equals(characterId));

            encounter.Initiatives.Remove(initiative);

            if (!encounter.Initiatives.Any())
            {
                var dm = _context.Characters.First(c => c.Name.Equals("Dungeon Master"));
                encounter.Initiatives.Add( new Initiative()
                {
                    Character = dm,
                    Roll = 20,
                    TurnOrder = 0
                });
            }

            _context.SaveChanges();
            return Json("We did it!");
        }

        [HttpPut]
        public JsonResult Update(int encounterId, List<int> newOrder)
        {
            var newInitiatives = new List<Initiative>();
            var encounter = _context.Encounters.First(e => e.Id.Equals(encounterId));

            var newInit = from i in newOrder
                join initiative in encounter.Initiatives
                    on i equals initiative.Character.Id
                select initiative;

            encounter.Initiatives = newInit.ToList();

            _context.SaveChanges();

            return Json("Yay");
        }

        [HttpPost]
        public JsonResult GetName(int characterId)
        {
            return Json(_context.Characters.First(c => c.Id.Equals(characterId)).Name);
        }
    }
}
