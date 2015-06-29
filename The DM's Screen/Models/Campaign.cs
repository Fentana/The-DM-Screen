using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheDmScreen.Models;

namespace TheDmScreen.Models
{
    public class Campaign
    {
        public int CampaignId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Encounter> Encounters { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
    }
}