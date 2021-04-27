using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats.Instances
{
    public class Constitution : AbstractStatTemplate
    {
        public static readonly Guid ID = Guid.Parse("10e9f065-a160-47e5-97df-72df4ec5ea15");

        protected override Stat GetStat()
        {
            return new Stat 
            {
                Id = ID,
                Name = "Constitution",
                Abbreviation = "CON", 
                Description = "Constitution measures your character’s overall health and stamina. Constitution is an important statistic for all characters, especially those who fight in close combat.  Your Constitution modifier is added to your Hit Points and Fortitude saving throws." 
            };
        }
    }
}
