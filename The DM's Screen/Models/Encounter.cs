using System.Data.Entity;
using System.Collections.Generic;

namespace TheDmScreen.Models
{
    public class Encounter
    {
        public int EncounterId { get; set; }
        public string BattleMapImage { get; set; }
        public virtual ICollection<Character> Participants { get; set; }
        public virtual ICollection<EncounterFeedEntry> FeedEntries { get; set; }

        public Encounter()
        {
            Participants = new HashSet<Character>();
            FeedEntries = new HashSet<EncounterFeedEntry>();
        }
    }

    public class EncounterFeedEntry
    {
        public int EncounterFeedEntryId { get; set; }
        public Character ActingCharacter { get; set; }
        public string Description { get; set; }
    }

    public class Character
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public string Portrait { get; set; }
        public virtual ICollection<Encounter> Encounters { get; set; }

        public Character()
        {
            Encounters = new HashSet<Encounter>();
        }
    }

    public class Campaign
    {
        public int CampaignId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Encounter> Encounters { get; set; }
        public virtual ICollection<Character> Characters { get; set; } 
    }

    public class EncounterFeedContext : DbContext
    {
        public EncounterFeedContext()
            : base("EncounterFeedDb")
        {
        }

        public DbSet<Encounter> Encounters { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<EncounterFeedEntry> Actions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Encounter>().
              HasMany(c => c.Participants).
              WithMany(p => p.Encounters).
              Map(m =>
               {
                   m.MapLeftKey("EncounterId");
                   m.MapRightKey("CharacterId");
                   m.ToTable("CharacterEncounters");
               });
        }
    }
}