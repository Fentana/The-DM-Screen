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
            var tyrannyOfDragons = new Campaign
            {
                Name = "The Tyranny of Dragons",
                Description =
                    "The Cult of the Dragon has risen in full force to summon the evil diety Tiamat from her imprisonment in Acheron, and only a ragtag group of adventurers can help unite the Sword Coast to stop them.",
            };

            var phandelver = new Campaign
            {
                Name = "Lost Mines of Phandelver",
                Description =
                    "The recently re-established pioneer town of Phandalin is being infiltrated by an unknown force, and it's a race to see who can find the spellforge within the Lost Mine of Phandelver: Wave Echo Cave.",
            };

            // Characters
            var dm = new Character
            {
                Name = "Dungeon Master",
                Portrait = "../../Content/Characters/dungeonmaster.jpg",
                Type = CharacterType.Player,
                Age = 1000,
                Status = "Omnipresent",
                Allegiance = "The System",
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Master", Level = 20 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    },
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var ellywick = new Character
            {
                Name = "Ellywick",
                Portrait = "../../Content/Characters/ellywick.jpg",
                Type = CharacterType.Player,
                Status = "Alive",
                Allegiance = "Unknown",
                Campaign = tyrannyOfDragons,
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class = "Rogue", Level = 6 },
                    new ClassAndLevel() { Class = "Wizard", Level = 3 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    },
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var hellbaby = new Character
            {
                Name = "Jaq Hellbaby",
                Portrait = "../../Content/Characters/hellbaby.gif",
                Type = CharacterType.Player,
                Status = "Alive",
                Allegiance = "Church of Tim",
                Age = 1000,
                Campaign = tyrannyOfDragons,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Warlock", Level = 8 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    },
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };
            
            var steelbeard = new Character
            {
                Name = "Adun Steelbeard",
                Portrait = "../../Content/Characters/steelbeard.jpg",
                Type = CharacterType.Player,
                Status = "Alive",
                Allegiance = "Church of Dawn",
                Age = 1000,
                Campaign = tyrannyOfDragons,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Cleric", Level = 9 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    },
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var randy = new Character
            {
                Name = "Randy Magnosh",
                Portrait = "../../Content/Characters/randy.jpg",
                Type = CharacterType.Player,
                Status = "Alive",
                Allegiance = "Church of Tim",
                Age = 1000,
                Campaign = tyrannyOfDragons,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Barbarian", Level = 5 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    },
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var varo = new Character
            {
                Name = "Varo Latrellis",
                Portrait = "../../Content/Characters/varo.jpg",
                Type = CharacterType.ListedUnique,
                Status = "Killed in Action",
                Allegiance = "Church of Tim",
                Age = 1000,
                Campaign = tyrannyOfDragons,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Artificer", Level = 6 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    },
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var jeff = new Character
            {
                Name = "Jeff",
                Portrait = "../../Content/Characters/jeff.jpg",
                Type = CharacterType.ListedUnique,
                Status = "Unknown",
                Allegiance = "Unknown",
                Age = 1000,
                Campaign = tyrannyOfDragons,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="???", Level = 8 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Acquisitions Incorporated",
                        ContentBody = "Before he was hired by Sir Isteval to manage the Church of Tim's establishment, Jeff was the manager of the Waterdeep branch of Acquisitions Incorporated. However, due to misguided faith in his own magical prowess (due in part to illusions cast by the wizard Jim Darkmagic of the New Hampshire Darkmagics), he was ruthlessly beaten by Flaming Fist mercenaries. Disgraced, he lived a life of petty accounting for several years until he contacted Sir Isteval to find a job."
                    },
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    },
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var trickfoot = new Character
            {
                Name = "Trickfoot",
                Portrait = "../../Content/Characters/trickfoot.png",
                Type = CharacterType.Player,
                Status = "Alive",
                Allegiance = "Unknown",
                Age = 1000,
                Campaign = tyrannyOfDragons,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Bard", Level = 9 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var amper = new Character
            {
                Name = "Amper Sand",
                Portrait = "../../Content/Characters/amper.jpg",
                Type = CharacterType.Player,
                Status = "Alive",
                Allegiance = "Unknown",
                Age = 1000,
                Campaign = phandelver,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Bard", Level = 2 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    },
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var aramil = new Character
            {
                Name = "Aramil",
                Portrait = "../../Content/Characters/aramil.jpg",
                Type = CharacterType.Player,
                Status = "Alive",
                Allegiance = "Unknown",
                Age = 1000,
                Campaign = phandelver,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Druid", Level = 2 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    },
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var beorn = new Character
            {
                Name = "Beorn Goddart",
                Portrait = "../../Content/Characters/beorn.gif",
                Type = CharacterType.Player,
                Status = "Alive",
                Allegiance = "Church of Torm",
                Age = 1000,
                Campaign = phandelver,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Paladin", Level = 2 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    },
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var pecos = new Character
            {
                Name = "Pecos",
                Portrait = "../../Content/Characters/pecos.jpg",
                Type = CharacterType.Player,
                Status = "Alive",
                Allegiance = "Unknown",
                Age = 1000,
                Campaign = phandelver,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Ranger", Level = 2 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    },
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var timekeeper = new Character
            {
                Name = "The Time Keeper",
                Portrait = "../../Content/Characters/timekeeper.jpg",
                Type = CharacterType.Player,
                Status = "Alive",
                Allegiance = "Unknown",
                Age = 1000,
                Campaign = phandelver,
                ClassesAndLevels = new List<ClassAndLevel>
                {
                    new ClassAndLevel() { Class="Wizard", Level = 2 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    },
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var redbrandRuffian = new Character
            {
                Name = "Redbrand Ruffian",
                Portrait = "../../Content/Monsters/ruffian.jpg",
                Type = CharacterType.Generic,
                Allegiance = "",
                Age = 1000,
                Campaign = phandelver,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var glassstaff = new Character
            {
                Name = "Glass Staff",
                Portrait = "../../Content/Characters/glassstaff.jpg",
                Type = CharacterType.UnlistedUnique,
                Allegiance = "Redbrand Marauders",
                Age = 1000,
                Campaign = phandelver,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    },
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var kingGrol = new Character
            {
                Name = "King Grol",
                Portrait = "../../Content/Characters/kinggrol.jpg",
                Type = CharacterType.ListedUnique,
                Allegiance = "Cragmaw Clan",
                Age = 1000,
                Campaign = phandelver,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 3 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var vyerith = new Character
            {
                Name = "Vyerith",
                Portrait = "../../Content/Characters/vyerith.jpg",
                Type = CharacterType.ListedUnique,
                Allegiance = "The Black Spider",
                Age = 1000,
                Campaign = phandelver,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 3 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var banshee = new Character
            {
                Name = "Banshee",
                Portrait = "../../Content/Monsters/banshee.jpg",
                Type = CharacterType.Generic,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var goblin = new Character
            {
                Name = "Goblin",
                Portrait = "../../Content/Monsters/goblin.jpg",
                Type = CharacterType.Generic,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var skeleton = new Character
            {
                Name = "Skeleton",
                Portrait = "../../Content/Monsters/skeleton.jpg",
                Type = CharacterType.Generic,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var nothic = new Character
            {
                Name = "Nothic",
                Portrait = "../../Content/Monsters/nothic.png",
                Type = CharacterType.Generic,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var orc = new Character
            {
                Name = "Orc",
                Portrait = "../../Content/Monsters/Orc.jpg",
                Type = CharacterType.Generic,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var owlbear = new Character
            {
                Name = "Owlbear",
                Portrait = "../../Content/Monsters/owlbear.jpg",
                Type = CharacterType.Generic,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var hobgoblin = new Character
            {
                Name = "Hobgoblin",
                Portrait = "../../Content/Monsters/hobgoblin.png",
                Type = CharacterType.Generic,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var bugbear = new Character
            {
                Name = "Bugbear",
                Portrait = "../../Content/Monsters/bugbear.jpg",
                Type = CharacterType.Generic,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var commoner = new Character
            {
                Name = "Commoner",
                Portrait = "../../Content/Monsters/commoner.jpg",
                Type = CharacterType.Generic,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            var wolf = new Character
            {
                Name = "Wolf",
                Portrait = "../../Content/Monsters/wolf.jpg",
                Type = CharacterType.Generic,
                Allegiance = "",
                Age = 1000,
                ClassesAndLevels = new List<ClassAndLevel>()
                {
                    new ClassAndLevel() { Class="CR", Level = 1 }
                },
                WikiSections = new List<WikiSection>
                {
                    new WikiSection()
                    {
                        Title = "Significant Event",
                        ContentBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dui arcu, faucibus a placerat venenatis, aliquet non nisl. Phasellus convallis eros a pharetra fermentum. Quisque venenatis erat enim, et malesuada justo vulputate gravida. Nulla feugiat ex diam, a mollis lacus iaculis id. Fusce ullamcorper quis lacus nec condimentum. Aenean ultrices arcu in semper consequat. Duis erat ex, venenatis id magna sit amet, blandit tempor nisi. Maecenas molestie turpis id augue elementum, id facilisis enim ultricies. Sed dapibus feugiat nulla."
                    }
                }
            };

            context.Characters.AddOrUpdate(
                p => p.Name, dm,

                // Tyranny of Dragons
                ellywick, hellbaby, steelbeard, trickfoot, randy, jeff, varo,

                // Lost Mines of Phandelver
                amper, aramil, beorn, pecos, timekeeper, redbrandRuffian, glassstaff, kingGrol, vyerith,

                // Others
                banshee, goblin, wolf, skeleton, orc, nothic, hobgoblin, bugbear, commoner, owlbear);

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

            tyrannyOfDragons.Episodes = new List<Episode>() {devastation};
            phandelver.Episodes = new List<Episode>() {phandalin};

            context.Campaigns.AddOrUpdate(
                p => p.Name,

                tyrannyOfDragons, phandelver);
        }
    }
}
