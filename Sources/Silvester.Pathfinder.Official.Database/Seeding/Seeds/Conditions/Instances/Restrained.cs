using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Restrained : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("ecb312a5-4e27-43b9-89ec-1a615d9f9dc2");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Restrained",
                Description = "You're tied up and can barely move, or a creature has you pinned. You have the flat-footed and immobilized conditions, and you can't use any actions with the attack or manipulate traits except to attempt to Escape or Force Open your bonds. Restrained overrides grabbed.",
                OverridesConditionId = Grabbed.ID
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("de1236fc-c4e3-4f46-b8e3-1f3e06b2314d"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 622
            };
        }
    }
}
