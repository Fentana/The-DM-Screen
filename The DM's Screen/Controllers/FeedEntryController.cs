using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheDmScreen.Models;

namespace TheDmScreen.Controllers
{
    public class FeedEntryController : Controller
    {
        private readonly DmScreenContext context;

        public FeedEntryController()
        {
            context = new DmScreenContext();
        }

        [HttpPost]
        public JsonResult Add(int encounterId, ICollection<int> newTurnOrder, string description)
        {   
            // hackish
            var actorId = newTurnOrder.First();

            var encounter = context.Encounters.First(e => e.EncounterId.Equals(encounterId));
            var actingCharacter = context.Characters.First(p => p.CharacterId.Equals(actorId));

            var feedEntry = new EncounterFeedEntry
            {
                ActingCharacter = actingCharacter,
                Description = description
            };
            context.Actions.Add(feedEntry);

            encounter.Initiatives.First(p => p.Character.CharacterId.Equals(newTurnOrder.ElementAt(0)))
                .TurnOrder = newTurnOrder.Count()-1;

            for(var i=1; i<newTurnOrder.Count(); ++i)
            {
                encounter.Initiatives.First(p => p.Character.CharacterId.Equals(newTurnOrder.ElementAt(i)))
                    .TurnOrder = i-1;
            }

            // Rotate the Turn Order
            //RotateInitiatives(encounter, actingCharacter);

            encounter.FeedEntries.Add(feedEntry);
            context.SaveChanges();

            return Json("Successfully posted");
        }

        [HttpPut]
        public JsonResult Skip(int encounterId)
        {
            var encounter = context.Encounters.First(e => e.EncounterId.Equals(encounterId));
            var actingCharacter = encounter.Initiatives.OrderBy(p => p.TurnOrder).First().Character;

            RotateInitiatives(encounter, actingCharacter);
            context.SaveChanges();

            return Json("Successfully rotated");
        }

        [HttpPut]
        public JsonResult Hold(int encounterId)
        {
            var encounter = context.Encounters.First(e => e.EncounterId.Equals(encounterId));
            var actingCharacter = encounter.Initiatives.OrderBy(p => p.TurnOrder).First().Character;

            RotateInitiatives(encounter, actingCharacter);
            context.SaveChanges();

            return Json("Successfully rotated");
        }

        [HttpGet]
        public PartialViewResult Edit(int entryId)
        {
            var entry = context.Actions.First(m => m.EncounterFeedEntryId.Equals(entryId));
            var encounter = context.Encounters.First(m => m.FeedEntries.Any(e => e.EncounterFeedEntryId.Equals(entryId)));

            var model = new EditEntryViewModel
            {
                FeedEntry = entry,
                Initiatives = encounter.Initiatives.OrderBy(c => c.Character.Name).ToList()
            };

            return PartialView("~/Views/Partials/EditEntry.cshtml", model);
        }

        [HttpPut]
        public JsonResult Update(int entryId, string description, int characterId)
        {
            var entry = context.Actions.First(e => e.EncounterFeedEntryId.Equals(entryId));

            if (entry.ActingCharacter.CharacterId != characterId)
            {
                var actingCharacter = context.Characters.First(c => c.CharacterId.Equals(characterId));

                entry.ActingCharacter = actingCharacter;
            }

            entry.Description = description;
            context.SaveChanges();

            return Json("Successfully updated");
        }

        [HttpPut]
        public JsonResult Delete(int entryId, string description)
        {
            var entry = context.Actions.First(e => e.EncounterFeedEntryId.Equals(entryId));

            context.Actions.Remove(entry);
            context.SaveChanges();

            return Json("Successfully deleted");
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
    }
}
