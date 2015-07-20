using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheDmScreen.Models;

namespace TheDmScreen.Controllers
{
    public class CharacterController : Controller
    {
        private readonly DmScreenContext context;

        public CharacterController()
        {
            context = new DmScreenContext();
        }

        public ActionResult Details(int id = 1)
        {
            var character = context.Characters.First(c => c.Id == id);

            return View(character);
        }
    }
}
