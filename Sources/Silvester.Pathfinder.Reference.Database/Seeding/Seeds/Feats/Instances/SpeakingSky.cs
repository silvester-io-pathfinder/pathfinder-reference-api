using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpeakingSky : Template
    {
        public static readonly Guid ID = Guid.Parse("43abde39-4d2b-4804-b860-db6877194510");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Speaking Sky",
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
            yield return new TextBlock { Id = Guid.Parse("e2101cfc-5974-4ce2-8d05-94a75cef5383"), Type = TextBlockType.Text, Text = "You can hear air movement like soft whispers. You gain the (spell: speaking sky) ki spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0aee5119-dd33-488a-b9c8-58ed1013b8a8"), Feats.Instances.JalmeriHeavenseekerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f83362c3-5a12-42f2-b184-01140f8c87a1"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
