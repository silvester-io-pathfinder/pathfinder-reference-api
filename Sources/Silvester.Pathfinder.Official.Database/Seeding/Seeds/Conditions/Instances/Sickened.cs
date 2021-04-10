using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Sickened : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("c674e766-939d-47fa-9c94-80173d59741f");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Sickened",
                Description = "You feel ill. Sickened always includes a value. You take a status penalty equal to this value on all your checks and DCs. You can't willingly ingest anything—including elixirs and potions—while sickened. You can spend a single action retching in an attempt to recover, which lets you immediately attempt a Fortitude save against the DC of the effect that made you sickened. On a success, you reduce your sickened value by 1 (or by 2 on a critical success).",
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b475166-4b71-4da5-b261-3b78d78adcde"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 622
            };
        }
    }
}
