using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Shove : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("5f6680fc-208d-44db-a85f-92d572120738");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Shove",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dce77167-3331-4d4e-9390-78486cad2c35"), Type = TextBlockType.Text, Text = "You can use this weapon to Shove with the Athletics skill even if you don’t have a free hand. This uses the weapon’s reach (if different from your own) and adds the weapon’s item bonus to attack rolls as an item bonus to the Athletics check. If you critically fail a check to Shove using the weapon, you can drop the weapon to take the effects of a failure instead of a critical failure." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("165590c3-009e-4508-a105-9c8a76b5f79a"),
                SourceId = CoreRulebook.ID,
                Page = 283
            };
        }
    }
}
