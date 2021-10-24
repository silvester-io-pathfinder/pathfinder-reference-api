using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rarities.Instances
{
    public class Uncommon : Template
    {
        public static readonly Guid ID = Guid.Parse("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0");

        protected override Rarity GetAncestryRarity()
        {
            return new Rarity
            {
                Id = ID,
                Name = "Uncommon"
            };
        }
    }
}
