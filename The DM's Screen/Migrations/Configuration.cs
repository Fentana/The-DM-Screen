using System.Collections.Generic;
using TheDmScreen.Models;

namespace The_DM_s_Screen.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TheDmScreen.Models.EncounterFeedContext>
    {
        public Configuration()
        {
            // ENABLED ONLY FOR DEVELOPMENT PURPOSES
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TheDmScreen.Models.EncounterFeedContext context)
        {
            // Characters
            var dm = new Character {Name = "Dungeon Master", Portrait = "../../Content/dungeonmaster.jpg"};
            var ellywick = new Character {Name = "Ellywick", Portrait = "../../Content/ellywick.jpg"};
            var hellbaby = new Character {Name = "Hellbaby", Portrait = "../../Content/hellbaby.gif"};
            var steelbeard = new Character {Name = "Steelbeard", Portrait = "../../Content/steelbeard.jpg"};
            var randy = new Character {Name = "Randy", Portrait = "../../Content/randy.jpg"};
            var varo = new Character {Name = "Varo", Portrait = "../../Content/varo.jpg"};
            var jeff = new Character {Name = "Jeff", Portrait = "../../Content/jeff.jpg"};
            var trickfoot = new Character {Name = "Trickfoot", Portrait = "../../Content/trickfoot.png"};
            var amper = new Character {Name = "Amper", Portrait = "../../Content/amper.jpg"};
            var aramil = new Character {Name = "Aramil", Portrait = "../../Content/aramil.jpg"};
            var beorn = new Character {Name = "Beorn Goddart", Portrait = "../../Content/beorn.gif"};
            var pecos = new Character {Name = "Pecos", Portrait = "../../Content/pecos.jpg"};
            var timekeeper = new Character {Name = "The Time Keeper", Portrait = "../../Content/timekeeper.jpg"};

            context.Characters.AddOrUpdate(
                p => p.Name, dm,
                
                // Tyranny of Dragons
                ellywick, hellbaby, steelbeard, trickfoot, randy, jeff, varo,
                
                // Lost Mines of Phandelver
                amper, aramil, beorn, pecos, timekeeper); 

            context.Campaigns.AddOrUpdate(
                p => p.Name,
                new Campaign
                {
                    Name = "Tyranny of Dragons",
                    Characters = new List<Character> { ellywick, hellbaby, steelbeard, trickfoot, randy, jeff, varo }
                },
                new Campaign
                {
                    Name = "Lost Mines of Phandelver",
                    Characters = new List<Character> { amper, aramil, beorn, pecos, timekeeper }
                });
        }
    }
}
