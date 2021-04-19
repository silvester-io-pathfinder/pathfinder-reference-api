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
    public class Doomed : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("824a03c0-0108-4896-8c0a-8af3a09cd738");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Doomed",
                ConditionCategoryId = seeder.GetCategoryByName("Death and Dying").Id
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8cf1621e-3546-4afa-a642-b9230fdb4738"), Type = Utilities.Text.TextBlockType.Text, Text = "A powerful force has gripped your soul, calling you closer to death. Doomed always includes a value. The dying value at which you die is reduced by your doomed value. If your maximum dying value is reduced to 0, you instantly die. When you die, you’re no longer doomed." };
            yield return new TextBlock { Id = Guid.Parse("78319886-dc7a-4b52-bf06-737bd98c21e3"), Type = Utilities.Text.TextBlockType.Text, Text = "Your doomed value decreases by 1 each time you get a full night’s rest." };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("9693cf88-cb25-468d-a60b-becb5e1077a4"),
                SourceId = CoreRulebook.ID,
                Page = 619
            };
        }
    }
}
