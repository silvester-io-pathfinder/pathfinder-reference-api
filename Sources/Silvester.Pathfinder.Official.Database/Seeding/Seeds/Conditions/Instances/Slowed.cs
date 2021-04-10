using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Slowed : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("f253f20f-d7d3-4fe6-bb19-8d521afd9436");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Slowed",
                Description = "You have fewer actions. Slowed always includes a value. When you regain your actions at the start of your turn, reduce the number of actions you regain by your slowed value. Because slowed has its effect at the start of your turn, you don't immediately lose actions if you become slowed during your turn.",
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("32ddb040-0f69-40b1-8c45-693df9034766"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 622
            };
        }
    }
}
