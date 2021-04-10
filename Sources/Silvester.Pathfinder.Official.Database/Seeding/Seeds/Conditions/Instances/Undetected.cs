using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Undetected : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("d7416bc0-79b9-42c0-9335-e420dd3e0f50");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Undetected",
                Description = "When you are undetected by a creature, that creature cannot see you at all, has no idea what space you occupy, and can't target you, though you still can be affected by abilities that target an area. When you're undetected by a creature, that creature is flat-footed to you. A creature you're undetected by can guess which square you're in to try targeting you. It must pick a square and attempt an attack.This works like targeting a hidden creature(requiring a DC 11 flat check), but the flat check and attack roll are rolled in secret by the GM, who doesn't reveal whether the attack missed due to failing the flat check, failing the attack roll, or choosing the wrong square. A creature can use the Seek action to try to find you.",
                ConditionCategoryId = seeder.GetCategoryByName("Degrees of Detection").Id,
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("8cbcb7fb-2032-4b91-a811-46753e66f848"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 623
            };
        }
    }
}
