using System.Data.Entity;
using System.Collections.Generic;
using TheDmScreen.Models;

namespace TheDmScreen.Models
{
    public class Encounter
    {
        public int EncounterId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public string BattleMapImage { get; set; }
        public virtual ICollection<Initiative> Initiatives { get; set; }
        public virtual ICollection<EncounterFeedEntry> FeedEntries { get; set; }

        public Encounter()
        {
            Initiatives = new List<Initiative>();
            FeedEntries = new List<EncounterFeedEntry>();
        }
    }
}