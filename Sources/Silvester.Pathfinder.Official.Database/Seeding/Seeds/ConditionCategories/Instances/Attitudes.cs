using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ConditionCategories.Instances
{
    public class Attitudes : AbstractConditionCategoryTemplate
    {
        public static readonly Guid ID = Guid.Parse("ae1f94c2-5442-4eed-bfdc-54a3faadbcc4");

        public override ConditionCategory GetConditionCategory()
        {
            return new ConditionCategory 
            {
                Id = ID, 
                Name = "Attitudes" 
            };
            
        }
    }
}
