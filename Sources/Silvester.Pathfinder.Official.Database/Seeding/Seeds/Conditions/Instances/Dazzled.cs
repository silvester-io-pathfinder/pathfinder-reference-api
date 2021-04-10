using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Dazzled : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("ff7b682f-13ff-464f-a230-89cc814186ea");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Dazzled",
                Description = "Your eyes are overstimulated. If vision is your only precise sense, all creatures and objects are concealed from you.",
                ConditionCategoryId = seeder.GetCategoryByName("Senses").Id
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("23bc81bd-d007-446b-acde-93d6586d4d24"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 619
            };
        }
    }
}
