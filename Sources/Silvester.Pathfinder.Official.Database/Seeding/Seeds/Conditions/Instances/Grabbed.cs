using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Grabbed : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("918a03c5-27d2-458f-8bbf-2d1933738415");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Grabbed",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("355e56d4-13ed-47e0-a9ca-9a79ce8d41b9"), Type = Utilities.Text.TextBlockType.Text, Text = "You’re held in place by another creature, giving you the flat-footed and immobilized conditions. If you attempt a manipulate action while grabbed, you must succeed at a DC 5 flat check or it is lost; roll the check after spending the action, but before any effects are applied." };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("d3c67fb1-62b1-4b8d-8017-1b913d634cff"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 620
            };
        }
    }
}
