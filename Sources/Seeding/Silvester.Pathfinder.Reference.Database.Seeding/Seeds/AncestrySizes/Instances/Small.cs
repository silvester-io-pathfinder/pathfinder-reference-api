using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AncestrySizes.Instances
{
    public class Small : Template
    {
        public static readonly Guid ID = Guid.Parse("0a06e806-0314-455c-8af8-c81ecc1e0dd2");

        protected override AncestrySize GetAncestrySize()
        {
            return new AncestrySize
            {
                Id = ID,
                Name = "Small",
                Space = 5, 
                BreadthReach = 5,
                HeightReach = 5
            };
        }
    }
}
