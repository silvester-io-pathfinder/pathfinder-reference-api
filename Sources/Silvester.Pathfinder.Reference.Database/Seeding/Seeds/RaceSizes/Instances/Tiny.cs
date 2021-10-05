using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.RaceSizes.Instances
{
    public class Tiny : Template
    {
        public static readonly Guid ID = Guid.Parse("f44c1295-604f-443b-9ecc-870d82264eb5");

        protected override RaceSize GetRaceSize()
        {
            return new RaceSize
            {
                Id = ID,
                Name = "Tiny",
                Space = 3, 
                BreadthReach = 0,
                HeightReach = 0 
            };
        }
    }
}
