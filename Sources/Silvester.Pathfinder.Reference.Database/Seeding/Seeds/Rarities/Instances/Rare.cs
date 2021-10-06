using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rarities.Instances
{
    public class Rare : Template
    {
        public static readonly Guid ID = Guid.Parse("863d10bd-583b-41e9-ae52-2d94cf0a2bff");

        protected override Rarity GetAncestryRarity()
        {
            return new Rarity
            {
                Id = ID,
                Name = "Rare"
            };
        }
    }
}
