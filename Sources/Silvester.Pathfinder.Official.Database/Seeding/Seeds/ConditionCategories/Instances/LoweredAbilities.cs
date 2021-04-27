using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ConditionCategories.Instances
{
    public class LoweredAbilities : AbstractConditionCategoryTemplate
    {
        public static readonly Guid ID = Guid.Parse("655ed530-4d75-4816-af14-4cbbdd19531e");

        public override ConditionCategory GetConditionCategory()
        {
            return new ConditionCategory 
            { 
                Id = ID, 
                Name = "Lowered Abilities" 
            };
        }
    }
}
