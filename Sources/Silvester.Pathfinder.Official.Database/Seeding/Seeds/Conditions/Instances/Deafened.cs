using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Deafened : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("31b26b64-2616-4d23-93de-f3dbc0c81b7d");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Deafened",
                Description = "You can't hear. You automatically critically fail Perception checks that require you to be able to hear. You take a –2 status penalty to Perception checks for initiative and checks that involve sound but also rely on other senses. If you perform an action with the auditory trait, you must succeed at a DC 5 flat check or the action is lost; attempt the check after spending the action but before any effects are applied. You are immune to auditory effects.",
                ConditionCategoryId = seeder.GetCategoryByName("Senses").Id
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("649223d0-1602-442a-8751-34c050b98392"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 619
            };
        }
    }
}
