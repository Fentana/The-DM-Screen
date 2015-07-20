using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheDmScreen.Models
{
    public class EncounterFeedEntry
    {
        public int Id { get; set; }
        public virtual Character ActingCharacter { get; set; }
        public string Description { get; set; }
    }
}