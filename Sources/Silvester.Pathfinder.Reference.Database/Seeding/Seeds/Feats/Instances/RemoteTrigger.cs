using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RemoteTrigger : Template
    {
        public static readonly Guid ID = Guid.Parse("aabf970a-bd12-469a-9816-25debead6707");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Remote Trigger",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3b623b0d-af95-43d1-8ab7-f89a8c463fdd"), Type = TextBlockType.Text, Text = "You’ve learned how to trigger snares from afar, creating ranged hazards to assail your opponents and allowing you to disarm enemies’ snares harmlessly. You can (action: Strike) a snare to trigger it prematurely. If you crafted the snare, you automatically hit. If someone else crafted it, attempt a ranged (action: Strike) against the Crafting DC, triggering the snare only if you hit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("548edf5a-1f38-4ed2-a890-69ca9f96c051"), Feats.Instances.SnarecrafterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("725ec51d-9465-4fec-a60c-11f7938ccf2a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
