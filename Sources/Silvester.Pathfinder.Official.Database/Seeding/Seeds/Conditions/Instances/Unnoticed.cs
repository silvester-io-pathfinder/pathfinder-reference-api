using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Unnoticed : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("43bea701-97ae-4ab1-8e30-e42fcff51f41");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Unnoticed",
                Description = "If you are unnoticed by a creature, that creature has no idea you are present at all. When you're unnoticed, you're also undetected by the creature. This condition matters for abilities that can be used only against targets totally unaware of your presence.",
                ConditionCategoryId = seeder.GetCategoryByName("Degrees of Detection").Id,
                OverridesConditionId = Dazzled.ID
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("6136be14-61d3-44fa-9e44-f2a5006a6098"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 623
            };
        }
    }
}
