using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceSizes.Instances
{
    public class Gargantuan : AbstractRaceSizeTemplate
    {
        public static readonly Guid ID = Guid.Parse("93daa531-f40c-4db8-8cc2-65f8e32b951b");

        protected override RaceSize GetRaceSize(RaceSizeSeeder seeder)
        {
            return new RaceSize
            {
                Id = ID,
                Name = "Gargantuan",
                Space = 20, 
                BreadthReach = 20,
                HeightReach = 15
            };
        }
    }
}
