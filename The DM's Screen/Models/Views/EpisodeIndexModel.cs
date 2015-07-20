using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheDmScreen.Models.Views
{
    public class EpisodeIndexModel
    {
        public Campaign Campaign { get; set; }
        public List<Character> Dossier { get; set; } 
    }
}