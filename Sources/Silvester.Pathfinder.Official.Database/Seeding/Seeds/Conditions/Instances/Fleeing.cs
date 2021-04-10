using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Fleeing : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("35e06ece-e68a-4201-a215-8e3a29f30840");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Fleeing",
                Description = "You're forced to run away due to fear or some other compulsion. On your turn, you must spend each of your actions trying to escape the source of the fleeing condition as expediently as possible (such as by using move actions to flee, or opening doors barring your escape). The source is usually the effect or caster that gave you the condition, though some effects might define something else as the source. You can't Delay or Ready while fleeing.",
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2e6c0f8-283e-4580-bec2-26abf8b586e7"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 620
            };
        }
    }
}
