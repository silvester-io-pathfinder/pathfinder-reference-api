using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ConditionCategories.Instances
{
    public class DegreesOfDetection : Template
    {
        public static readonly Guid ID = Guid.Parse("d104a1f4-fb11-45c3-84b7-14880d673095");

        public override ConditionCategory GetConditionCategory()
        {
            return new ConditionCategory 
            { 
                Id = ID, 
                Name = "Degrees of Detection"
            };
        }
    }
}
