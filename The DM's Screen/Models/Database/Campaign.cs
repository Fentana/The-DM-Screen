﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheDmScreen.Models;

namespace TheDmScreen.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }
    }
}