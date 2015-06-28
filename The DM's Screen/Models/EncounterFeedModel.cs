using System.Data.Entity;
using System.Collections.Generic;

namespace TheDmScreen.Models
{
    public class EncounterFeedModel
    {
        public IEnumerable<Character> TurnOrder;
        public IEnumerable<EncounterFeedEntry> FeedEntries;
        public string BattleMapImage;
        public bool DrawDmDrawer;
    }

    public class EncounterFeedEntry
    {
        public Character ActingCharacter;
        public string Description;
    }

    public class Character
    {
        public string Name;
        public string Portrait;
    }

    // I'll deal with this in a bit
    public class EncounterFeedContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<EncounterFeedEntry> Actions { get; set; }
    }
}