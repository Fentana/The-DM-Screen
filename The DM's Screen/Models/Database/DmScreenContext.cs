using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TheDmScreen.Models;

namespace TheDmScreen.Models
{
    public class DmScreenContext : DbContext
    {
        public DmScreenContext()
            : base("DmScreenContext")
        {
        }

        public DbSet<EncounterFeedEntry> Actions { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Encounter> Encounters { get; set; }
        public DbSet<Episode> Episodes { get; set; }
    }
}