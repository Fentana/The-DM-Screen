using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheDmScreen.Models
{
    public class Initiative
    {
        public int InitiativeId { get; set; }
        public virtual Character Character { get; set; }
        public int TurnOrder { get; set; }
    }
}