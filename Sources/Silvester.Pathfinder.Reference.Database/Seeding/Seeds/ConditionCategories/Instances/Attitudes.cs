using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ConditionCategories.Instances
{
    public class Attitudes : Template
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
