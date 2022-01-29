using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DomainAcumen : Template
    {
        public static readonly Guid ID = Guid.Parse("40ccdae1-2631-4e43-b145-e338ab9cd1cb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Domain Acumen",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8b997e5a-ea60-484f-bef4-52a1abaf36a1"), Type = TextBlockType.Text, Text = $"Every oracle's mystery touches on a divine domain of the deities that fuel it; you can access that power. Choose one of the domains associated with your mystery for which you don't already have an initial domain spell. You gain an initial domain spell from that domain, which you cast as a revelation spell. It gains the {ToMarkdownLink<Models.Entities.Trait>("cursebound", Traits.Instances.Cursebound.ID)} trait. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("efe3200c-dcd8-4770-8b05-2125f96dabbf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
