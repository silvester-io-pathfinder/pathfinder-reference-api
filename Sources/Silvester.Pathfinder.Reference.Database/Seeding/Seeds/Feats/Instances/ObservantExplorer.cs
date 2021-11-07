using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ObservantExplorer : Template
    {
        public static readonly Guid ID = Guid.Parse("48881a66-a969-406b-b3c4-f816c5bb5eba");

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
            yield return new TextBlock { Id = Guid.Parse("5a00e279-909e-427d-a695-406491fc5d40"), Type = TextBlockType.Text, Text = "Thanks to the time you&#39;ve spent wandering through wild and untamed environments, you&#39;ve gained an intuitive sense about creatures. You sometimes notice them before they attack, or spot them nearby even if they weren&#39;t planning on attacking. You can attempt a check to notice hidden creatures attempting to (action: Avoid Notice) nearby even if you aren&#39;t actively (action: Searching | Search) for them. You still need to meet any other requirements to notice a particular creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c7de772f-2e98-4778-9f88-8e0057d9d1c1"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c19c375-53b5-4476-ab64-1a38354d4758"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
