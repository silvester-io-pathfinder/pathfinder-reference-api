using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AncestrySizes.Instances
{
    public class Large : Template
    {
        public static readonly Guid ID = Guid.Parse("abe0e587-0fda-48d3-9206-1d43e727bcab");

        protected override AncestrySize GetAncestrySize()
        {
            return new AncestrySize
            {
                Id = ID,
                Name = "Large",
                Space = 10, 
                BreadthReach = 10,
                HeightReach = 5
            };
        }
    }
}
