using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Rarities.Instances
{
    public class Unique : Template
    {
        public static readonly Guid ID = Guid.Parse("cd8cbe89-8d6d-4dee-aee3-7c2d2b8980dc");

        protected override Rarity GetRaceRarity()
        {
            return new Rarity
            {
                Id = ID,
                Name = "Unique"
            };
        }
    }
}
