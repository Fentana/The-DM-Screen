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
            var campaign = context.Campaigns.First(c => c.Id.Equals(campaignId));

            return View(campaign);
        }

        [HttpGet]
        public PartialViewResult Add(int campaignId)
        {
            var campaign = context.Campaigns.First(c => c.Id.Equals(campaignId));

            return PartialView(campaign);
        }

        [HttpPut]
        public JsonResult Add(int campaignId, string name, string description, string summary)
        {
            var campaign = context.Campaigns.First(c => c.Id.Equals(campaignId));

            campaign.Episodes.Add(new Episode()
            {
                Name = name,
                Description = description,
                Summary = summary,
                Order = campaign.Episodes.Count(),
            });

            context.SaveChanges();

            return Json("Yes");
        }
    }
}
