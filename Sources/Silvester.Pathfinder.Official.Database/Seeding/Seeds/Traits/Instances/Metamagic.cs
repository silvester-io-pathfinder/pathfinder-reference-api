using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Metamagic : Template
    {
        public static readonly Guid ID = Guid.Parse("0b39858c-3039-4774-86f4-0c3fa9c4fabd");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Metamagic",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("823c9e9a-6144-49d0-b214-174265dcb756"), Type = TextBlockType.Text, Text = "Actions with the metamagic trait, usually from metamagic feats, tweak the properties of your spells. You must use a metamagic action directly before Casting the Spell you want to alter. If you use any action (including free actions and reactions) other than Cast a Spell directly after, you waste the benefits of the metamagic action. Any additional effects added by a metamagic action are part of the spell’s effect, not of the metamagic action itself." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae69134b-595f-4aa2-92da-484cfdce6c0e"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
