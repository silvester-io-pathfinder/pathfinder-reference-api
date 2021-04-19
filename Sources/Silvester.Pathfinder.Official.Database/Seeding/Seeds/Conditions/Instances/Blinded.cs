using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Blinded : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("e9e00854-3d42-48b7-9724-017c8a46e3c0");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Blinded",
                ConditionCategoryId = seeder.GetCategoryByName("Senses").Id,
                OverridesConditionId = Dazzled.ID
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("de7bc05a-0a68-407f-9325-18b58b3e4ef1"), Type = Utilities.Text.TextBlockType.Text, Text = "You can’t see. All normal terrain is difficult terrain to you. You can’t detect anything using vision. You automatically critically fail Perception checks that require you to be able to see, and if vision is your only precise sense, you take a –4 status penalty to Perception checks. You are immune to visual effects. Blinded overrides dazzled." };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("f743a373-99c3-4e37-973a-cd274745c865"),
                SourceId = CoreRulebook.ID,
                Page = 618
            };
        }
    }
}
