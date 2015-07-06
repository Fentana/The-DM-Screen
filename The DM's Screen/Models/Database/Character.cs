using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheDmScreen.Models;
using TheDmScreen.Models.Database;

namespace TheDmScreen.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public string Portrait { get; set; }
        public bool IsPlayer { get; set; }
        public bool IsUnique { get; set; }
        public virtual ICollection<Inventory> Inventory { get; set; }

        // Summaries
        public int Age { get; set; }
        public string Status { get; set; } // Deceased?
        public virtual ICollection<string> ClassesAndLevels { get; set; } 
        public virtual ICollection<WikiSection> WikiSections { get; set; }

        // Stats
        public int? Strength { get; set; }
        public int? Dexterity { get; set; }
        public int? Constitution { get; set; }
        public int? Intelligence { get; set; }
        public int? Wisdom { get; set; }
        public int? Charisma { get; set; }

        public Character()
        {
            Inventory = new List<Inventory>();
        }
    }
}