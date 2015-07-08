using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheDmScreen.Models;
using TheDmScreen.Models.Views;

namespace TheDmScreen.Controllers
{
    public class EpisodeController : Controller
    {
        private readonly DmScreenContext _context;

        public EpisodeController()
        {
            _context = new DmScreenContext();
        }

        public ActionResult Index(int campaignId)
        {
            var campaign = _context.Campaigns.First(c => c.Id.Equals(campaignId));
            var dossier = _context.Characters.Where(c => c.Campaign.Id == campaignId)
                    .Where(n => n.Type == CharacterType.Player || n.Type == CharacterType.ListedUnique);

            return View(new EpisodeIndexModel()
            {
                Campaign = campaign,
                Dossier = dossier.ToList()
            });
        }

        [HttpGet]
        public PartialViewResult Add(int campaignId)
        {
            var campaign = _context.Campaigns.First(c => c.Id.Equals(campaignId));

            return PartialView(campaign);
        }

        [HttpPut]
        public JsonResult Add(int campaignId, string name, string description, string summary)
        {
            var campaign = _context.Campaigns.First(c => c.Id.Equals(campaignId));

            campaign.Episodes.Add(new Episode()
            {
                Name = name,
                Description = description,
                Summary = summary,
                Order = campaign.Episodes.Count(),
            });

            _context.SaveChanges();

            return Json("Yes");
        }
    }
}
