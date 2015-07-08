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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Portrait { get; set; }
        public CharacterType Type { get; set; }
        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual Campaign Campaign { get; set; }

        // Summaries
        public int Age { get; set; }
        public string Status { get; set; } // Deceased?
        public string Allegiance { get; set; }
        public virtual ICollection<ClassAndLevel> ClassesAndLevels { get; set; } 
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
            WikiSections = new List<WikiSection>();
            ClassesAndLevels = new List<ClassAndLevel>();
        }
    }

    public enum CharacterType
    {
        Player,         // Players
        ListedUnique,   // NPCs or unique monsters that should be listed in the Dossier
        UnlistedUnique, // NPCs or unique monsters that should not be listed in the Dossier
        Template,       // Something like "Half-Dragon Template"
        Generic         // Goblins, etc.
    }
}