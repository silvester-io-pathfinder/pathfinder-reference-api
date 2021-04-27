using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class TwoHand : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("fd2bc373-0742-4272-9d1f-6740d7c5f149");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Two-Hand",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("088a7fc0-3d68-46c3-bf35-ebed5deceb3d"), Type = TextBlockType.Text, Text = "This weapon can be wielded with two hands. Doing so changes its weapon damage die to the indicated value. This change applies to all the weapon’s damage dice, such as those from striking runes." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("157f5882-b53f-4737-9273-176d5120a399"),
                SourceId = CoreRulebook.ID,
                Page = 283
            };
        }
    }
}
