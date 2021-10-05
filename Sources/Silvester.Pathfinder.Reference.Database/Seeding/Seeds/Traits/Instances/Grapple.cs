using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Grapple : Template
    {
        public static readonly Guid ID = Guid.Parse("052112be-3cbc-4ca8-bf6f-32587afd62d2");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Grapple",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d1cecdcc-86cd-4688-8627-f22cc612252f"), Type = TextBlockType.Text, Text = "You can use this weapon to Grapple with the Athletics skill even if you don’t have a free hand. This uses the weapon’s reach (if different from your own) and adds the weapon’s item bonus to attack rolls as an item bonus to the Athletics check. If you critically fail a check to Grapple using the weapon, you can drop the weapon to take the effects of a failure instead of a critical failure." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1fbc8993-975e-4b38-ac96-c06e9a966f63"),
                SourceId = CoreRulebook.ID,
                Page = 283
            };
        }
    }
}
