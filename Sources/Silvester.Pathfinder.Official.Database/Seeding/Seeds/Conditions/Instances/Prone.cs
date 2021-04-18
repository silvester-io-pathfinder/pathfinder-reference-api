using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Prone : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("b680a37e-cf30-4c4b-886f-a713282892af");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Prone",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("39ddfdbd-c9a1-47eb-aa6b-96bc572fefda"), Type = Utilities.Text.TextBlockType.Text, Text = "You’re lying on the ground. You are flat-footed and take a –2 circumstance penalty to attack rolls. The only move actions you can use while you’re prone are Crawl and Stand. Standing up ends the prone condition. You can Take Cover while prone to hunker down and gain greater cover against ranged attacks, even if you don’t have an object to get behind, gaining a +4 circumstance bonus to AC against ranged attacks (but you remain flat-footed)." };
            yield return new TextBlock { Id = Guid.Parse("7fe8edf9-1e44-4603-bbab-612a53f2dbc8"), Type = Utilities.Text.TextBlockType.Text, Text = "If you would be knocked prone while you’re Climbing or Flying, you fall (see pages 463–464 for the rules on falling). You can’t be knocked prone when Swimming." };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("c928cb5b-b048-4877-9e65-d9e394ff0936"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 621
            };
        }
    }
}
