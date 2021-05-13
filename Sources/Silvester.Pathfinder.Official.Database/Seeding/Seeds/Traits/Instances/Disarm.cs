using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Disarm : Template
    {
        public static readonly Guid ID = Guid.Parse("f20a1378-da0f-4259-9631-a31ff5ca19e7");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Disarm",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0e7ee76f-6bdf-474e-bba3-37549c8b72ab"), Type = TextBlockType.Text, Text = "You can use this weapon to Disarm with the Athletics skill even if you don’t have a free hand. This uses the weapon’s reach (if different from your own) and adds the weapon’s item bonus to attack rolls (if any) as an item bonus to the Athletics check. If you critically fail a check to Disarm using the weapon, you can drop the weapon to take the effects of a failure instead of a critical failure. On a critical success, you still need a free hand if you want to take the item." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4742d46-eea2-4216-9e2a-ce613ec2473e"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
