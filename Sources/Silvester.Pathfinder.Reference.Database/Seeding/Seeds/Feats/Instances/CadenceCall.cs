using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CadenceCall : Template
    {
        public static readonly Guid ID = Guid.Parse("a3191437-db36-416a-b13d-9ad96b3fa46e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cadence Call",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("062297a7-0557-40c2-932b-241c62aab6b8"), Type = TextBlockType.Text, Text = "You call out a quick cadence, guiding your allies into a more efficient rhythm. Each willing ally within your marshal’s aura is quickened until the end of their next turn, and they can use the extra action only to (action: Stride). At the end of each ally’s turn, if they used the extra action, they then become slowed 1 until the end of their following turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7523d822-b1a8-472a-ae71-454e7d77a180"), Feats.Instances.MarshalDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("145b1ea9-b375-4c81-bb55-8f4cf66ff77c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
