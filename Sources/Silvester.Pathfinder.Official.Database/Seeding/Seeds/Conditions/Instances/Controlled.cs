using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Controlled : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("d4d10f5f-e6cc-4acc-a8b3-3a29de451366");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Controlled",
                Description = "Someone else is making your decisions for you, usually because you're being commanded or magically dominated. The controller dictates how you act and can make you use any of your actions, including attacks, reactions, or even Delay. The controller usually does not have to spend their own actions when controlling you.",
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6317e26-779a-4558-afa5-525a9be21ca5"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 618
            };
        }
    }
}
