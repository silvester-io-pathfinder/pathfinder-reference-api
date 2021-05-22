using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.HazardComplexities.Instances
{
    public class Simple : Template
    {
        public static readonly Guid ID = Guid.Parse("bac94513-a759-47b1-843f-3acb4946e83b");
     
        protected override HazardComplexity GetHazardComplexity()
        {
            return new HazardComplexity
            { 
                Id = ID, 
                Name = "Simple" 
            };
        }
    }
}
