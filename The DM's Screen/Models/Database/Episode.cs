using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheDmScreen.Models
{
    public class Episode
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public virtual ICollection<Encounter> Encounters { get; set; }
    }
}