using Silvester.Pathfinder.Official.Database.Models;
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
                Description = "You're lying on the ground. You are flat-footed and take a –2 circumstance penalty to attack rolls. The only move actions you can use while you're prone are Crawl and Stand. Standing up ends the prone condition. You can Take Cover while prone to hunker down and gain greater cover against ranged attacks, even if you don't have an object to get behind, gaining a +4 circumstance bonus to AC against ranged attacks (but you remain flat-footed). If you would be knocked prone while you're Climbing or Flying, you fall (see Falling for the rules on falling). You can't be knocked prone when Swimming.",
            };
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
