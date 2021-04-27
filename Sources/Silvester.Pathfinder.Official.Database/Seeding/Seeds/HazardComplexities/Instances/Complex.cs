using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.HazardComplexities.Instances
{
    public class Complex : AbstractHazardComplexityTemplate
    {
        public static readonly Guid ID = Guid.Parse("dcc2b25e-1b95-401a-8fc6-17f1e1ee7cbb");
        
        protected override HazardComplexity GetHazardComplexity()
        {
            return new HazardComplexity 
            {
                Id = ID, 
                Name = "Complex" 
            };
        }
    }
}
