using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpeedyRituals : Template
    {
        public static readonly Guid ID = Guid.Parse("fc7415da-d3f7-478f-b8f8-0ae7646f10d8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Speedy Rituals",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("23fd9a35-7e3a-4e57-9903-2d6d12350c63"), Type = TextBlockType.Text, Text = "You can perform rituals in only a fraction of the usual time. If a ritual has a casting time measured in days, you can cast it in an equal number of hours. If this results in a ritual longer than 8 hours, you split the ritual between multiple days, as normal for a ritual." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("57fbad64-faa5-4f8a-804d-6d0596d25a91"), Feats.Instances.EfficientRitualist.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5299401-3bd8-48aa-83c9-9bf9ad72a3a0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
