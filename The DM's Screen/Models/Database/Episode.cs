using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheDmScreen.Models
{
    public class Episode
    {
        public int EpisodeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Encounter> Encounters { get; set; }
    }
}