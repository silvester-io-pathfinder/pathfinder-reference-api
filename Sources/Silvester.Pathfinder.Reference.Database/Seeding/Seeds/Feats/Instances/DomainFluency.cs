using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DomainFluency : Template
    {
        public static readonly Guid ID = Guid.Parse("7eda7c18-2459-4f6d-b0c9-55fdf5dc725b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Domain Fluency",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7cd66145-5b00-4f23-b415-938eaa071ab3"), Type = TextBlockType.Text, Text = "You command a deep understanding of the divine domains related to your mystery. Choose one of the domains associated with your mystery for which you have an initial domain spell. You gain an advanced domain spell from that domain, which you cast as a revelation spell, causing it to gain the (trait: cursebound) trait. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f8b2f7a0-6206-453c-b105-fe7b0bce60bd"), Feats.Instances.DomainInitiate.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f0a8d8f-5a63-4c72-a7ae-e9302b36b907"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
