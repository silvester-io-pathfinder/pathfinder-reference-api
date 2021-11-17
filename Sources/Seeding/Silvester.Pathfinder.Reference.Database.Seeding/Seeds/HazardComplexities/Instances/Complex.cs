using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HazardComplexities.Instances
{
    public class Complex : Template
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
