using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Spasming : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("d9b38c43-deee-4d47-a5a8-ee48ab4daa2d");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Spasming",
                Description = "You are conflicted with sudden spasms. The rulebooks do not mention any particular effects of spasming, so it is best left up to the discretion of the GM."
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return null;
        }
    }
}
