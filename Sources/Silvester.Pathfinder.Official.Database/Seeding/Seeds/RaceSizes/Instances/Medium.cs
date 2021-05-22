using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceSizes.Instances
{
    public class Medium : Template
    {
        public static readonly Guid ID = Guid.Parse("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991");

        protected override RaceSize GetRaceSize()
        {
            return new RaceSize
            {
                Id = ID,
                Name = "Medium",
                Space = 5, 
                BreadthReach = 5,
                HeightReach = 5
            };
        }
    }
}
