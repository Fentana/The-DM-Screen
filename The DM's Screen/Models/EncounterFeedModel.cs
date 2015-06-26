using System.Collections.Generic;

namespace TheDmScreen.Models
{
    public class EncounterFeedModel
    {
        public IEnumerable<Character> TurnOrder;
        public IEnumerable<EncounterFeedEntry> FeedEntries;
    }

    public struct EncounterFeedEntry
    {
        public Character ActingCharacter;
        public List<string> Actions;
    }

    public class Character
    {
        public string Name;
        public string Portrait;
    }
}