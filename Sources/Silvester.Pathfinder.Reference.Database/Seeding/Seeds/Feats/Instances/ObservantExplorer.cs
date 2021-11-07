using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ObservantExplorer : Template
    {
        public static readonly Guid ID = Guid.Parse("e2b06970-b999-4cae-86c6-4e359f7c0279");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Observant Explorer",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f096558-25e2-442e-8c8f-cdd5acce1dad"), Type = TextBlockType.Text, Text = "Thanks to the time you&#39;ve spent wandering through wild and untamed environments, you&#39;ve gained an intuitive sense about creatures. You sometimes notice them before they attack, or spot them nearby even if they weren&#39;t planning on attacking. You can attempt a check to notice hidden creatures attempting to (action: Avoid Notice) nearby even if you aren&#39;t actively (action: Searching | Search) for them. You still need to meet any other requirements to notice a particular creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ebdbf0b0-6963-4358-84d7-eb94ccc22957"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2c5fec6-6c9d-4c1f-b466-8932ad4da9e3"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
