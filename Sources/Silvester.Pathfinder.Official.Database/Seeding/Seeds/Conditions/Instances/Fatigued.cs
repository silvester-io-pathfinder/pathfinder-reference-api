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
    public class Fatigued : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("48d6ee37-8a18-4162-9164-9f7892045d2d");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Fatigued",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b53d24af-320c-4f46-b25a-d65dd014713b"), Type = Utilities.Text.TextBlockType.Text, Text = "You’re tired and can’t summon much energy. You take a –1 status penalty to AC and saving throws. You can’t use exploration activities performed while traveling, such as those on pages 479–480." };
            yield return new TextBlock { Id = Guid.Parse("ab4a8033-4de6-4f8c-bd8c-8576da289805"), Type = Utilities.Text.TextBlockType.Text, Text = "You recover from fatigue after a full night’s rest." };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("7130351e-ad82-4ca7-b613-20b8743f03e3"),
                SourceId = CoreRulebook.ID,
                Page = 620
            };
        }
    }
}
