using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Stats.Instances
{
    public class Dexterity : Template
    {
        public static readonly Guid ID = Guid.Parse("21b2cca1-66cd-48d1-a91b-085521659548");

        protected override Stat GetStat()
        {
            return new Stat
            {
                Id = ID,
                Name = "Dexterity", 
                Abbreviation = "DEX", 
                Description = "Dexterity measures your character’s agility, balance, and reflexes. Dexterity is important if your character plans to make attacks with ranged weapons or use stealth to surprise foes. Your Dexterity modifier is also added to your character’s AC and Reflex saving throws." 
            };
        }
    }
}
