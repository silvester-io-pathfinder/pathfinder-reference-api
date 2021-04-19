using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceSizes.Instances
{
    public class Medium : AbstractRaceSizeTemplate
    {
        public static readonly Guid ID = Guid.Parse("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991");

        protected override RaceSize GetRaceSize(RaceSizeSeeder seeder)
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
