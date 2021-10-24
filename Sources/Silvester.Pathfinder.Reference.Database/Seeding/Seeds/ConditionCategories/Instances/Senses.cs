using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ConditionCategories.Instances
{
    public class Senses : Template
    {
        public static readonly Guid ID = Guid.Parse("224d0ea9-af56-49b9-946d-ce809b894701");

        public override ConditionCategory GetConditionCategory()
        {
            return new ConditionCategory 
            {
                Id = ID, 
                Name = "Senses" 
            };
        }
    }
}
