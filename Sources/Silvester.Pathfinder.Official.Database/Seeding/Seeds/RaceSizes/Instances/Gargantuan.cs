using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceSizes.Instances
{
    public class Gargantuan : AbstractRaceSizeTemplate
    {
        public static readonly Guid ID = Guid.Parse("93daa531-f40c-4db8-8cc2-65f8e32b951b");

        protected override RaceSize GetRaceSize()
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
