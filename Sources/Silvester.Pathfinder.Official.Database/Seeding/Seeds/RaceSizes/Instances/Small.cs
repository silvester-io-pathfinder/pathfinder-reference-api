using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceSizes.Instances
{
    public class Small : AbstractRaceSizeTemplate
    {
        public static readonly Guid ID = Guid.Parse("0a06e806-0314-455c-8af8-c81ecc1e0dd2");

        protected override RaceSize GetRaceSize(RaceSizeSeeder seeder)
        {
            return new RaceSize
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
