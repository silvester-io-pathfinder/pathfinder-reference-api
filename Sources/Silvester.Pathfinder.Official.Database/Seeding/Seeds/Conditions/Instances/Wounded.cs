using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Wounded : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("8f6d81d5-64f1-455e-80c8-7835accb6613");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Wounded",
                Description = "You have been seriously injured. If you lose the dying condition and do not already have the wounded condition, you become wounded 1. If you already have the wounded condition when you lose the dying condition, your wounded condition value increases by 1. If you gain the dying condition while wounded, increase your dying condition value by your wounded value. The wounded condition ends if someone successfully restores Hit Points to you with Treat Wounds, or if you are restored to full Hit Points and rest for 10 minutes.",
                ConditionCategoryId = seeder.GetCategoryByName("Death and Dying").Id
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("344af983-0fdd-4623-be6c-59587595cfe5"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 623
            };
        }
    }
}
