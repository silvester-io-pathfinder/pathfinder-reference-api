using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SwapInvestment : Template
    {
        public static readonly Guid ID = Guid.Parse("e89b0e2a-1b12-4298-8548-e81ca5373896");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Swap Investment",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("790cc0aa-0e6a-4a87-b687-1931af1ada20"), Type = TextBlockType.Text, Text = "Your time as a Pathfinder has taught you how to improvise, and you&#39;ve learned to make use of the resources you find in the field. You Invest a magic item and remove a previously invested item. The previous item no longer counts against your limit of 10 invested items." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d27ee43e-774c-4d14-b2fe-18e5842c6ae8"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("51e10064-a6a0-43df-9ad7-234dee81f835"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
