using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Rarities.Instances
{
    public class Common : Template
    {
        public static readonly Guid ID = Guid.Parse("52091c82-7a39-4a66-919e-ac268375b792");

        protected override Rarity GetRaceRarity()
        {
            return new Rarity
            {
                Id = ID,
                Name = "Common"
            };
        }
    }
}
