using System.Collections.Generic;
using TheDmScreen.Models;

namespace TheDmScreen.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TheDmScreen.Models.DmScreenContext>
    {
        public Configuration()
        {
            // ENABLED ONLY FOR DEVELOPMENT PURPOSES
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TheDmScreen.Models.DmScreenContext context)
        {
            // Characters
            var dm = new Character {Name = "Dungeon Master", Portrait = "../../Content/dungeonmaster.jpg", IsPlayer = false, IsUnique = true};
            var ellywick = new Character { Name = "Ellywick", Portrait = "../../Content/ellywick.jpg", IsPlayer = true, IsUnique = true };
            var hellbaby = new Character { Name = "Hellbaby", Portrait = "../../Content/hellbaby.gif", IsPlayer = true, IsUnique = true };
            var steelbeard = new Character { Name = "Steelbeard", Portrait = "../../Content/steelbeard.jpg", IsPlayer = true, IsUnique = true };
            var randy = new Character { Name = "Randy", Portrait = "../../Content/randy.jpg", IsPlayer = true, IsUnique = true };
            var varo = new Character { Name = "Varo", Portrait = "../../Content/varo.jpg", IsPlayer = false, IsUnique = true };
            var jeff = new Character { Name = "Jeff", Portrait = "../../Content/jeff.jpg", IsPlayer = false, IsUnique = true };
            var trickfoot = new Character { Name = "Trickfoot", Portrait = "../../Content/trickfoot.png", IsPlayer = true, IsUnique = true };
            var amper = new Character { Name = "Amper", Portrait = "../../Content/amper.jpg", IsPlayer = true, IsUnique = true };
            var aramil = new Character { Name = "Aramil", Portrait = "../../Content/aramil.jpg", IsPlayer = true, IsUnique = true };
            var beorn = new Character { Name = "Beorn Goddart", Portrait = "../../Content/beorn.gif", IsPlayer = true, IsUnique = true };
            var pecos = new Character { Name = "Pecos", Portrait = "../../Content/pecos.jpg", IsPlayer = true, IsUnique = true };
            var timekeeper = new Character { Name = "The Time Keeper", Portrait = "../../Content/timekeeper.jpg", IsPlayer = true, IsUnique = true };
            var redbrandRuffian = new Character { Name = "Redbrand Ruffian", Portrait = "../../Content/timekeeper.jpg", IsPlayer = false, IsUnique = false};

            context.Characters.AddOrUpdate(
                p => p.Name, dm,
                
                // Tyranny of Dragons
                ellywick, hellbaby, steelbeard, trickfoot, randy, jeff, varo,
                
                // Lost Mines of Phandelver
                amper, aramil, beorn, pecos, timekeeper, redbrandRuffian); 

            context.Campaigns.AddOrUpdate(
                p => p.Name,
                new Campaign
                {
                    Name = "The Tyranny of Dragons",
                    Description = "The Cult of the Dragon has risen in full force to summon the evil diety Tiamat from her imprisonment in Acheron, and only a ragtag group of adventurers can help unite the Sword Coast to stop them.",
                    Characters = new List<Character> { ellywick, hellbaby, steelbeard, trickfoot, randy, jeff, varo }
                },
                new Campaign
                {
                    Name = "Lost Mines of Phandelver",
                    Description = "The recently re-established pioneer town of Phandalin is being infiltrated by an unknown force, and it's a race to see who can find the spellforge within the Lost Mine of Phandelver: Wave Echo Cave.",
                    Characters = new List<Character> { amper, aramil, beorn, pecos, timekeeper, redbrandRuffian }
                });
        }
    }
}
