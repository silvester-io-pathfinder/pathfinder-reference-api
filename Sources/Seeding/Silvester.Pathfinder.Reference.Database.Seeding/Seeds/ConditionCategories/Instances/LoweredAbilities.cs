using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ConditionCategories.Instances
{
    public class LoweredAbilities : Template
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
