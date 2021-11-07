using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnareHopping : Template
    {
        public static readonly Guid ID = Guid.Parse("df7070f6-30fb-44c7-96b0-7bf6e2888506");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snare Hopping",
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
            yield return new TextBlock { Id = Guid.Parse("ab69e0da-3ecc-4aac-8884-2a57840c4d4f"), Type = TextBlockType.Text, Text = "You can magically move your snares around. You gain the (spell: snare hopping) warden spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("25316611-dd3d-4232-b2b0-7599bdf78677"), Feats.Instances.SnareCrafting.ID);
            builder.HaveSpecificClass(Guid.Parse("c2bb30eb-8067-4968-a76b-b39f0b2ac12b"), Classes.Instances.Ranger.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e4447d9-6222-49fc-b2dc-1057cfce14e2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
