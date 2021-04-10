using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Helpful : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("170bff5c-bcac-433d-94a0-840da90112af");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Helpful",
                Description = "This condition reflects a creature's disposition toward a particular character, and only supernatural effects (like a spell) can impose this condition on a PC. A creature that is helpful to a character wishes to actively aid that character. It will accept reasonable Requests from that character, as long as such requests aren't at the expense of the helpful creature's goals or quality of life. If the character or one of their allies uses a hostile action against the creature, the creature gains a worse attitude condition depending on the severity of the hostile action, as determined by the GM.",
                ConditionCategoryId = seeder.GetCategoryByName("Attitudes").Id
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("6abe2c10-38b3-4b54-b11d-b1914e99b198"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 620
            };
        }
    }
}
