using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Nonlethal : Template
    {
        public static readonly Guid ID = Guid.Parse("5ff19688-da1d-413b-8766-a37df3e95ca1");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Nonlethal",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d0b4308d-961a-4921-9bf5-813f75553bde"), Type = TextBlockType.Text, Text = "An effect with this trait is not inherently deadly. Damage from a nonlethal effect knocks a creature out rather than killing it. You can use a nonlethal weapon to make a lethal attack with a –2 circumstance penalty." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f863f3b8-62d2-4ea6-97a9-37115241b37a"),
                SourceId = CoreRulebook.ID,
                Page = 283
            };
        }
    }
}
