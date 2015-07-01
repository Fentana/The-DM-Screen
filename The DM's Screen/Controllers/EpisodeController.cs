using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheDmScreen.Models;

namespace TheDmScreen.Controllers
{
    public class EpisodeController : Controller
    {
        private readonly DmScreenContext context;

        public EpisodeController()
        {
            context = new DmScreenContext();
        }

        public ActionResult Index(int campaignId)
        {
            var campaign = context.Campaigns.First(c => c.CampaignId.Equals(campaignId));

            return View(campaign);
        }
    }
}
