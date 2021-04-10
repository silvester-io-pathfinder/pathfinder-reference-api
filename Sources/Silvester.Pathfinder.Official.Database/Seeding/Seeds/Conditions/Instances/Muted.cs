using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Muted : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("b0cbbc02-bec0-4b21-9b61-8af5bb2fc62b");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Muted",
                Description = "You are unable to communicate verbally with anyone. Additionally, you cannot cast any spells that have a verbal component to it, or activate an item that hase a command component to it.",
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return null;
        }
    }
}
