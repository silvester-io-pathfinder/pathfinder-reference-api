using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class WeighedDown : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("a2d387ce-eec5-439b-9e2e-2ef38f0ff3fb");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Weighed Down",
                Description = "You are weighed down, either physically, magically or otherwise. You take a penalty to all your movement speeds, but your speed can never be reduced below 5 feet.",
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return null;
        }
    }
}
