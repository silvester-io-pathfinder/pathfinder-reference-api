using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Unfriendly : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("ca2e35fe-8529-4ba3-a860-1bbde1c1c8f8");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Unfriendly",
                Description = "This condition reflects a creature's disposition toward a particular character, and only supernatural effects (like a spell) can impose this condition on a PC. A creature that is unfriendly to a character dislikes and specifically distrusts that character. The unfriendly creature won't accept Requests from the character.",
                ConditionCategoryId = seeder.GetCategoryByName("Attitudes").Id,
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("3eadd81e-0338-4b94-85a0-6939831d8396"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 623
            };
        }
    }
}
