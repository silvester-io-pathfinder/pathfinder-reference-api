using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceSizes.Instances
{
    public class Huge : Template
    {
        public static readonly Guid ID = Guid.Parse("eba80c08-8f5b-4dee-8d43-f1aa5fc30d8b");
        
        protected override RaceSize GetRaceSize()
        {
            return new RaceSize
            {
                Id = ID,
                Name = "Huge",
                Space = 15, 
                BreadthReach = 15,
                HeightReach = 20
            };
        }
    }
}
