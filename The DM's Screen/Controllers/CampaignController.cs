using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheDmScreen.Models;

namespace TheDmScreen.Controllers
{
    public class CampaignController : Controller
    {
        private readonly DmScreenContext context;

        public CampaignController()
        {
            context = new DmScreenContext();
        }

        public ActionResult Index()
        {
            var campaignList = context.Campaigns.OrderBy(c => c.Name).Take(10).ToList();

            return View(campaignList);
        }
    }
}
