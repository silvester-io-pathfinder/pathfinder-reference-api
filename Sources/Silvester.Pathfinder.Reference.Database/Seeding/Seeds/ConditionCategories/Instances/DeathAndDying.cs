using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ConditionCategories.Instances
{
    public class DeathAndDying : Template
    {
        public static readonly Guid ID = Guid.Parse("18744a3c-8c8d-4298-8be7-f5e7e5dc0a6b");

        public override ConditionCategory GetConditionCategory()
        {
            return new ConditionCategory 
            { 
                Id = ID, 
                Name = "Death and Dying" 
            };
        }
    }
}
