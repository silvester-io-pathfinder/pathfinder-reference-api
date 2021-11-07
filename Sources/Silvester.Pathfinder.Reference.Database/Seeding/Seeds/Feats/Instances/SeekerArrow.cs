using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SeekerArrow : Template
    {
        public static readonly Guid ID = Guid.Parse("e2b3178e-d714-4d0a-8edc-884d201a5b7a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Seeker Arrow",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bb17c503-bf8b-411e-8543-9bc53f3f9c42"), Type = TextBlockType.Text, Text = "Your shots zip around corners and fly at impossible angles to reach your target. Make a bow (action: Strike) against a foe you can see; the ammunition travels to your target, even around corners. You ignore the target’s concealed condition and all cover." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("60ef34a1-d92a-4aaa-9b6d-bff7ceb18457"), Feats.Instances.EldritchArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3804f9a0-dcf9-46e0-b695-19d26c66e04a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
