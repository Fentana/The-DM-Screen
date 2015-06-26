using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TheDmScreen.Models;

namespace TheDmScreen.Controllers
{
    public class InitiativeController : Controller
    {
        //
        // GET: /Initiative/

        // TODO: Add Database so we don't have to populate all of this nonsense here
        public ActionResult Tracker()
        {
            var timeKeeper = new Character()
            {
                Name = "The Time Keeper",
                Portrait = "../../Content/timekeeper.jpg"
            };

            var pecos = new Character()
            {
                Name = "Pecos",
                Portrait = "../../Content/pecosbill.jpg"
            };

            var beorn = new Character()
            {
                Name = "Beorn Goddart",
                Portrait = "../../Content/beorn.gif"
            };

            var aramil = new Character()
            {
                Name = "Aramil",
                Portrait = "../../Content/aramil.jpg"
            };

            var amper = new Character()
            {
                Name = "Amper",
                Portrait = "../../Content/amper.jpg"
            };

            var klarg = new Character()
            {
                Name = "Klarg",
                Portrait = "../../Content/klarg.jpg"
            };

            var model = new EncounterFeedModel
            {
                // Hardcoded, should be populated... somehow
                TurnOrder = new List<Character>()
                {
                    beorn, amper, klarg, pecos, aramil, timeKeeper
                },
                FeedEntries = new List<EncounterFeedEntry>()
                {
                    new EncounterFeedEntry()
                    {
                        ActingCharacter = timeKeeper,
                        Actions = new List<string>()
                        {
                            "Casts Time Ray on Klarg, dealing 13 \"time\" (cold) damage"
                        }
                    },
                    new EncounterFeedEntry()
                    {
                        ActingCharacter = aramil,
                        Actions = new List<string>()
                        {
                            "Casts \"Goodberry\" and consumes 5 berries, regaining 5 HP",
                            "Gives 5 berries to Amper"
                        }
                    },
                    new EncounterFeedEntry()
                    {
                        ActingCharacter = pecos,
                        Actions = new List<string>()
                        {
                            "Looses an arrow from his bow at Klarg, which was unfortunately deflected by Klarg"
                        }
                    },
                    new EncounterFeedEntry()
                    {
                        ActingCharacter = klarg,
                        Actions = new List<string>()
                        {
                            "Wails on Amper with his Morningstar, dealing 16 bludgeoning damage"
                        }
                    },
                    new EncounterFeedEntry()
                    {
                        ActingCharacter = amper,
                        Actions = new List<string>()
                        {
                            "Performs a song to bardically inspire Beorn, who may now add 1d8 to any roll of his choice"
                        }
                    },
                    new EncounterFeedEntry()
                    {
                        ActingCharacter = beorn,
                        Actions = new List<string>()
                        {
                            "Uses \"Lay on Hands\" to revive Aramil with 1 HP",
                            "Readies his Shield of Faith and prepares for an attack"
                        }
                    },
                    new EncounterFeedEntry()
                    {
                        ActingCharacter = timeKeeper,
                        Actions = new List<string>()
                        {
                            "Throws a \"Ball of Time\" at Klarg, but Klarg dodges out of the way"
                        }
                    }
                }
            };

            return View(model);
        }
    }
}
