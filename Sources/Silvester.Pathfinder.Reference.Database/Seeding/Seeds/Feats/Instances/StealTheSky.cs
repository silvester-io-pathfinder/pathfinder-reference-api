using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StealTheSky : Template
    {
        public static readonly Guid ID = Guid.Parse("4dd8f3a2-5717-4965-bf49-b6f7da52b296");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steal the Sky",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e788ec70-dfcb-4847-9724-83a3a8e87bb8"), Type = TextBlockType.Text, Text = "You can take away the air that keeps a flying foe aloft. You gain the (spell: steal the sky) ki spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("17365c26-5ec0-4f42-be97-58f458654df5"), Feats.Instances.JalmeriHeavenseekerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("796b0a43-a2b0-4eb9-ba16-ced89343efe0"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
