using System.Collections.Generic;
using TheDmScreen.Models;
using TheDmScreen.Models.Database;

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
            var dm = new Character
            {
                Name = "Dungeon Master",
                Portrait = "../../Content/dungeonmaster.jpg",
                IsPlayer = false, IsUnique = true,
                Age = 1000,
                Status = "Omnipresent",
                Allegiance = "The System",
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Master", Level = 20 }
                },
                WikiSections = new List<WikiSection>()
            };

            var ellywick = new Character
            {
                Name = "Ellywick", 
                Portrait = "../../Content/ellywick.jpg",
                IsPlayer = true,
                IsUnique = true,
                Status = "Alive",
                Allegiance = "Unknown",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class = "Rogue", Level = 6 },
                    new ClassAndLevel() { Class = "Wizard", Level = 3 }
                },
                WikiSections = new List<WikiSection>()
            };

            var hellbaby = new Character
            {
                Name = "Hellbaby", 
                Portrait = "../../Content/hellbaby.gif",
                IsPlayer = true,
                IsUnique = true,
                Status = "Alive",
                Allegiance = "Church of Tim",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Warlock", Level = 8 }
                },
                WikiSections = new List<WikiSection>()
            };
            
            var steelbeard = new Character
            {
                Name = "Steelbeard", 
                Portrait = "../../Content/steelbeard.jpg",
                IsPlayer = true,
                IsUnique = true,
                Status = "Alive",
                Allegiance = "Church of Dawn",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Cleric", Level = 9 }
                },
                WikiSections = new List<WikiSection>()
            };

            var randy = new Character
            {
                Name = "Randy", 
                Portrait = "../../Content/randy.jpg",
                IsPlayer = true,
                IsUnique = true,
                Status = "Alive",
                Allegiance = "Church of Tim",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Barbarian", Level = 5 }
                },
                WikiSections = new List<WikiSection>()
            };

            var varo = new Character
            {
                Name = "Varo", 
                Portrait = "../../Content/varo.jpg",
                IsPlayer = false,
                IsUnique = true,
                Status = "Killed in Action",
                Allegiance = "Church of Tim",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Artificer", Level = 6 }
                },
                WikiSections = new List<WikiSection>()
            };

            var jeff = new Character
            {
                Name = "Jeff", 
                Portrait = "../../Content/jeff.jpg",
                IsPlayer = false,
                IsUnique = true,
                Status = "Unknown",
                Allegiance = "Unknown",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="???", Level = 8 }
                },
                WikiSections = new List<WikiSection>()
            };

            var trickfoot = new Character
            {
                Name = "Trickfoot", 
                Portrait = "../../Content/trickfoot.png",
                IsPlayer = true,
                IsUnique = true,
                Status = "Alive",
                Allegiance = "Unknown",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Bard", Level = 9 }
                },
                WikiSections = new List<WikiSection>()
            };

            var amper = new Character
            {
                Name = "Amper", 
                Portrait = "../../Content/amper.jpg",
                IsPlayer = true,
                IsUnique = true,
                Status = "Alive",
                Allegiance = "Unknown",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Bard", Level = 2 }
                },
                WikiSections = new List<WikiSection>()
            };

            var aramil = new Character
            {
                Name = "Aramil", 
                Portrait = "../../Content/aramil.jpg",
                IsPlayer = true,
                IsUnique = true,
                Status = "Alive",
                Allegiance = "Unknown",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Druid", Level = 2 }
                },
                WikiSections = new List<WikiSection>()
            };

            var beorn = new Character
            {
                Name = "Beorn Goddart",
                Portrait = "../../Content/beorn.gif",
                IsPlayer = true,
                IsUnique = true,
                Status = "Alive",
                Allegiance = "Church of Torm",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Paladin", Level = 2 }
                },
                WikiSections = new List<WikiSection>()
            };

            var pecos = new Character
            {
                Name = "Pecos", 
                Portrait = "../../Content/pecos.jpg",
                IsPlayer = true,
                IsUnique = true,
                Status = "Alive",
                Allegiance = "Unknown",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Ranger", Level = 2 }
                },
                WikiSections = new List<WikiSection>()
            };

            var timekeeper = new Character
            {
                Name = "The Time Keeper", 
                Portrait = "../../Content/timekeeper.jpg",
                IsPlayer = true,
                IsUnique = true,
                Status = "Alive",
                Allegiance = "Unknown",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Wizard", Level = 2 }
                },
                WikiSections = new List<WikiSection>()
            };

            var redbrandRuffian = new Character
            {
                Name = "Redbrand Ruffian", 
                Portrait = "../../Content/ruffian.jpg",
                IsPlayer = false,
                IsUnique = false,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>()
            };

            var glassstaff = new Character
            {
                Name = "Glass Staff", 
                Portrait = "../../Content/glassstaff.jpg",
                IsPlayer = false,
                IsUnique = true,
                Allegiance = "Redbrand Marauders",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>()
            };

            var banshee = new Character
            {
                Name = "Banshee", 
                Portrait = "../../Content/banshee.jpg",
                IsPlayer = false,
                IsUnique = false,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>()
            };

            var goblin = new Character
            {
                Name = "Goblin", 
                Portrait = "../../Content/goblin.jpg",
                IsPlayer = false,
                IsUnique = false,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>()
            };

            var wolf = new Character
            {
                Name = "Wolf", 
                Portrait = "../../Content/wolf.jpg",
                IsPlayer = false,
                IsUnique = false,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>()
            };

            var skeleton = new Character
            {
                Name = "Skeleton", 
                Portrait = "../../Content/skeleton.jpg",
                IsPlayer = false,
                IsUnique = false,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>()
            };

            var orc = new Character
            {
                Name = "Orc", 
                Portrait = "../../Content/Orc.jpg",
                IsPlayer = false,
                IsUnique = false,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>()
            };

            var nothic = new Character
            {
                Name = "Nothic", 
                Portrait = "../../Content/nothic.png",
                IsPlayer = false,
                IsUnique = false,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>()
            };

            var hobgoblin = new Character
            {
                Name = "Hobgoblin", 
                Portrait = "../../Content/hobgoblin.png",
                IsPlayer = false,
                IsUnique = false,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>()
            };

            var bugbear = new Character
            {
                Name = "Bugbear", 
                Portrait = "../../Content/bugbear.png",
                IsPlayer = false,
                IsUnique = false,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>()
            };

            var commoner = new Character
            {
                Name = "Commoner", 
                Portrait = "../../Content/commoner.jpg",
                IsPlayer = false,
                IsUnique = false,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>()
            };

            context.Characters.AddOrUpdate(
                p => p.Name, dm,

                // Tyranny of Dragons
                ellywick, hellbaby, steelbeard, trickfoot, randy, jeff, varo,

                // Lost Mines of Phandelver
                amper, aramil, beorn, pecos, timekeeper, redbrandRuffian, glassstaff,

                // Others
                banshee, goblin, wolf, skeleton, orc, nothic, hobgoblin, bugbear, commoner);

            var scuffle = new Encounter()
            {
                BattleMapImage = "",
                Name = "Scuffle at the Sleeping Giant",
                Description = "The party is confronted by several Redbrand Ruffians on the porch of the Sleeping Giant Tap House",
                Initiatives = new List<Initiative>()
                {
                    new Initiative()
                    {
                        Character = dm,
                        Roll = 0
                    }
                }
            };
            var littleRustMonsters = new Encounter()
            {
                BattleMapImage = "",
                Name = "Little Rust Monsters",
                Description = "Hellbaby decides to kill some adorable little rust monsters",
                Order = 0,
                Initiatives = new List<Initiative>()
                {
                    new Initiative()
                    {
                        Character = dm,
                        Roll = 0
                    }
                }
            };
            var guardians = new Encounter()
            {
                BattleMapImage = "",
                Name = "Guardians of Yan-C-Bin",
                Description = "Ancient Air Myrmidons, guardians of the Temple of Air, come to life to stop our heroes from proceeding with Windvane",
                Order = 1,
                Initiatives = new List<Initiative>()
                {
                    new Initiative()
                    {
                        Character = dm,
                        Roll = 0
                    }
                }
            };
            var controller = new Encounter()
            {
                BattleMapImage = "",
                Name = "The Controller",
                Description = "The heroes are confronted by a man in black robes sitting in a room by himself. They make a choice and accidentally unleash The Controller.",
                Order = 2,
                Initiatives = new List<Initiative>()
                {
                    new Initiative()
                    {
                        Character = dm,
                        Roll = 0
                    }
                }
            };
            var showdown = new Encounter()
            {
                BattleMapImage = "",
                Name = "Showdown for the Devastation Orb",
                Description = "Nefermandias, Ramine Sandalpho, and three Red Wizards of Thay confront the party all at once",
                Order = 3,
                Initiatives = new List<Initiative>()
                {
                    new Initiative()
                    {
                        Character = dm,
                        Roll = 0
                    }
                }
            };

            var devastation = new Episode()
            {
                Name = "On the Quest for the Air Devasatation Orb",
                Summary = "After ten days of trudging through the Great Wastse, our heroes finally arrived in Ñloktl. The village was ruined and heavily eroded -- and surrounded by a giant dust storm. As they explored the town, they found a circular stone in the ground. Though heavily marred by erosion, the stone still contained several symbols, one of which was of a dragon.",
                Description = "The party embarks on a long, arduous journey through the Great Wastes to find the ancient ruined city of Ñloktl. It is there that they hope to find the Air Devastation Orb with the hopes of using it to stop the Cult of The Dragon.",
                Encounters = new List<Encounter>() { littleRustMonsters, guardians, controller, showdown },
                Order = 0
            };

            var phandalin = new Episode()
            {
                Name = "Phandalin, the Town with a History",
                Description = "The heroes reach Phandalin after rescuing Sildar Whatshisface and cause a ruckus",
                Summary = "You can't win them maul",
                Encounters = new List<Encounter>() { scuffle }
            };

            context.Campaigns.AddOrUpdate(
                p => p.Name,
                new Campaign
                {
                    Name = "The Tyranny of Dragons",
                    Description = "The Cult of the Dragon has risen in full force to summon the evil diety Tiamat from her imprisonment in Acheron, and only a ragtag group of adventurers can help unite the Sword Coast to stop them.",
                    Characters = new List<Character> { ellywick, hellbaby, steelbeard, trickfoot, randy, jeff, varo },
                    Episodes = new List<Episode>() { devastation }
                },
                new Campaign
                {
                    Name = "Lost Mines of Phandelver",
                    Description = "The recently re-established pioneer town of Phandalin is being infiltrated by an unknown force, and it's a race to see who can find the spellforge within the Lost Mine of Phandelver: Wave Echo Cave.",
                    Characters = new List<Character> { amper, aramil, beorn, pecos, timekeeper, redbrandRuffian, glassstaff },
                    Episodes = new List<Episode>() { phandalin }
                });
        }
    }
}
