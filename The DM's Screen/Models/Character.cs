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
        public virtual ICollection<Encounter> Encounters { get; set; }

        public Character()
        {
            Encounters = new List<Encounter>();
        }
    }
}