using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DomainAcumen : Template
    {
        public static readonly Guid ID = Guid.Parse("dea6a995-9d47-4143-9a6c-79791691c9ad");

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
            yield return new TextBlock { Id = Guid.Parse("c7a735c6-bd03-41a3-b94a-5c53eec2898b"), Type = TextBlockType.Text, Text = "Every oracle’s mystery touches on a divine domain of the deities that fuel it; you can access that power. Choose one of the domains associated with your mystery for which you don’t already have an initial domain spell. You gain an initial domain spell from that domain, which you cast as a revelation spell. It gains the (trait: cursebound) trait. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0ef1f64-4ed4-4962-994c-eac1657ce69f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
