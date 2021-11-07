using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PlantEvidence : Template
    {
        public static readonly Guid ID = Guid.Parse("ed4c9c27-549c-4baf-8ba3-fa0d712a6703");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Plant Evidence",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a2cd7464-7ce3-4851-b1a8-894b8ea7fcb5"), Type = TextBlockType.Text, Text = "You can put a single item you’re holding of light or negligible Bulk onto a person without them noticing by succeeding at a Thievery check against their Perception DC. If you have the ruffian racket, you can do this as a free action when you successfully (action: Shove) a target." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fb93ea65-a880-4007-a712-cfcc50b2548e"), Feats.Instances.Pickpocket.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0100e52c-c8c4-4e68-960c-3c3b2d0f3773"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
