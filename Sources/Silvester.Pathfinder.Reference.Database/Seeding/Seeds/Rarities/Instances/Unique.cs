using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rarities.Instances
{
    public class Unique : Template
    {
        public static readonly Guid ID = Guid.Parse("cd8cbe89-8d6d-4dee-aee3-7c2d2b8980dc");

        protected override Rarity GetAncestryRarity()
        {
            return new Rarity
            {
                Id = ID,
                Name = "Unique"
            };
        }
    }
}
