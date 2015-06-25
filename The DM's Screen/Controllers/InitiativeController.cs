using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace The_DM_s_Screen.Models
{
    public class InitiativeController : Controller
    {
        //
        // GET: /Initiative/

        public ActionResult Tracker()
        {
            var model = new TurnOrderModel
            {
                TurnOrder = new List<string>()
                {
                    "Amper",
                    "Aramil",
                    "Beorn Goddart",
                    "Pecos",
                    "The Time Keeper",
                    "Klarg"
                }
            };

            return View(model);
        }

        public List<string> GetTurnOrder()
        {
            return new List<string>();
        }
    }
}
