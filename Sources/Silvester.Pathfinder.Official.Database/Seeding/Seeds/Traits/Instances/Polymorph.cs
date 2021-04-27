using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Polymorph : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("0d5ac0f8-6c22-45b2-81e6-5eb6bfcbb9e2");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Polymorph",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("15b80e80-7363-4415-bce9-9ad29b00dcd6"), Type = TextBlockType.Text, Text = "These effects transform the target into a new form. A target can’t be under the effect of more than one polymorph effect at a time. If it comes under the effect of a second polymorph effect, the second polymorph effect attempts to counteract the first. If it succeeds, it takes effect, and if it fails, the spell has no effect on that target. Any Strikes specifically granted by a polymorph effect are magical. Unless otherwise stated, polymorph spells don’t allow the target to take on the appearance of a specific individual creature, but rather just a generic creature of a general type or ancestry." };
            yield return new TextBlock { Id = Guid.Parse("0ac72a91-2825-44e6-a3ca-670c0f6c5fb7"), Type = TextBlockType.Text, Text = "If you take on a battle form with a polymorph spell, the special statistics can be adjusted only by circumstance bonuses, status bonuses, and penalties. Unless otherwise noted, the battle form prevents you from casting spells, speaking, and using most manipulate actions that require hands. (If there’s doubt about whether you can use an action, the GM decides.) Your gear is absorbed into you; the constant abilities of your gear still function, but you can’t activate any items." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c072829a-5a27-4879-85b6-d54af0ad7998"),
                SourceId = CoreRulebook.ID,
                Page = 635
            };
        }
    }
}
