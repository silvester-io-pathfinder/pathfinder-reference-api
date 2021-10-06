using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rarities.Instances
{
    public class Common : Template
    {
        public static readonly Guid ID = Guid.Parse("52091c82-7a39-4a66-919e-ac268375b792");

        protected override Rarity GetAncestryRarity()
        {
            return new Rarity
            {
                Id = ID,
                Name = "Common"
            };
        }
    }
}
