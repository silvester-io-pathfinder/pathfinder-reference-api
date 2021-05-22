using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Trip : Template
    {
        public static readonly Guid ID = Guid.Parse("01eb7172-c3df-4c6e-a13f-43522445f2b3");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Trip",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8fc2bf54-c07d-4f6e-926d-c2f2c463b3ad"), Type = TextBlockType.Text, Text = "You can use this weapon to Trip with the Athletics skill even if you don’t have a free hand. This uses the weapon’s reach (if different from your own) and adds the weapon’s item bonus to attack rolls as an item bonus to the Athletics check. If you critically fail a check to Trip using the weapon, you can drop the weapon to take the effects of a failure instead of a critical failure." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95c24371-051e-4a39-a13f-6f639d9c1917"),
                SourceId = CoreRulebook.ID,
                Page = 283
            };
        }
    }
}
