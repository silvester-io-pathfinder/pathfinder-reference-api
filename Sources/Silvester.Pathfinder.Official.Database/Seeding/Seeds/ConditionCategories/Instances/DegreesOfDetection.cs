using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ConditionCategories.Instances
{
    public class DegreesOfDetection : AbstractConditionCategoryTemplate
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
