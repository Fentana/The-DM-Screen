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
