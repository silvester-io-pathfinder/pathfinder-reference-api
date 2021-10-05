using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Twin : Template
    {
        public static readonly Guid ID = Guid.Parse("f6da7ca3-bdb3-4c89-9cd8-4161fcc564c5");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Twin",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f308cf1-74dc-42cf-a82a-6c0ee2a959d4"), Type = TextBlockType.Text, Text = "These weapons are used as a pair, complementing each other. When you attack with a twin weapon, you add a circumstance bonus to the damage roll equal to the weapon’s number of damage dice if you have previously attacked with a different weapon of the same type this turn. The weapons must be of the same type to benefit from this trait, but they don’t need to have the same runes." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("44555d48-efb2-4b0d-92cd-ed6aeb4e6802"),
                SourceId = CoreRulebook.ID,
                Page = 283
            };
        }
    }
}
