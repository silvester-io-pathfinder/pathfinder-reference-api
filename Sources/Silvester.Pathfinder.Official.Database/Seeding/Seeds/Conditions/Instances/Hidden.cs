using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Hidden : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("4f1b10d8-98e2-43f2-b3a4-22e6b11ea699");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Hidden",
                Description = "While you're hidden from a creature, that creature knows the space you're in but can't tell precisely where you are. You typically become hidden by using Stealth to Hide. When Seeking a creature using only imprecise senses, it remains hidden, rather than observed. A creature you're hidden from is flat-footed to you, and it must succeed at a DC 11 flat check when targeting you with an attack, spell, or other effect or it fails to affect you. Area effects aren't subject to this flat check. A creature might be able to use the Seek action to try to observe you.",
                ConditionCategoryId = seeder.GetCategoryByName("Degrees of Detection").Id
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("9af352ee-666e-46a3-a976-2d1f0be4bef5"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 620
            };
        }
    }
}
