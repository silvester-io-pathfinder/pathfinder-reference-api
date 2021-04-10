using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Friendly : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("87851575-72a5-4935-b284-7cb0551fadf2");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Friendly",
                Description = "This condition reflects a creature's disposition toward a particular character, and only supernatural effects (like a spell) can impose this condition on a PC. A creature that is friendly to a character likes that character. The character can attempt to Make a Request of a friendly creature, and the friendly creature is likely to agree to a simple and safe request that doesn't cost it much to fulfill. If the character or one of their allies uses hostile actions against the creature, the creature gains a worse attitude condition depending on the severity of the hostile action, as determined by the GM.",
                ConditionCategoryId = seeder.GetCategoryByName("Attitudes").Id
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("22f3b334-9d9c-49fa-890f-e8a869daabc7"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 620
            };
        }
    }
}
