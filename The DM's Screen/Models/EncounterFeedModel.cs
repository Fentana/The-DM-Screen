using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace The_DM_s_Screen.Models
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

    public struct Character
    {
        public string Name;
        public string Portrait;
    }
}