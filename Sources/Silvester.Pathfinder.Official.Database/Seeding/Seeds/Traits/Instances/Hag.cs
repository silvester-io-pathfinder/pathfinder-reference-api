using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Hag : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("d891aba2-87c0-41a5-823a-6f853f85a2d5");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Hag",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("de242a81-cb39-41a2-8066-6c91daef62ee"), Type = TextBlockType.Text, Text = "These creatures are malevolent spellcasters who form covens." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a782851f-30f3-4ec0-b619-93c504ec7716"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
