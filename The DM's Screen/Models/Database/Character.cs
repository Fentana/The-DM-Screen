using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheDmScreen.Models;

namespace TheDmScreen.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public string Portrait { get; set; }
        public bool IsPlayer { get; set; }
        public bool IsUnique { get; set; }
        public virtual ICollection<Encounter> Encounters { get; set; }

        // For future reference
        public int? Strength { get; set; }
        public int? Dexterity { get; set; }
        public int? Constitution { get; set; }
        public int? Intelligence { get; set; }
        public int? Wisdom { get; set; }
        public int? Charisma { get; set; }

        public Character()
        {
            Encounters = new List<Encounter>();
        }
    }
}