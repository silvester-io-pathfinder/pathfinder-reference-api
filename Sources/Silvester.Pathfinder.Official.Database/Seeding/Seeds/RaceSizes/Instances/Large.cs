using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceSizes.Instances
{
    public class Large : AbstractRaceSizeTemplate
    {
        public static readonly Guid ID = Guid.Parse("abe0e587-0fda-48d3-9206-1d43e727bcab");

        protected override RaceSize GetRaceSize()
        {
            return new RaceSize
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
