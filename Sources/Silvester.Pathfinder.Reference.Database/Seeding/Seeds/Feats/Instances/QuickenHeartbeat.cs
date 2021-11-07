using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickenHeartbeat : Template
    {
        public static readonly Guid ID = Guid.Parse("43ffbead-b552-4eb8-906f-a37330125bd0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quicken Heartbeat",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per turn"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bde76008-872f-4b4a-bd12-e4a84fa23554"), Type = TextBlockType.Text, Text = "You’ve replaced your heart with one made of animated quicksilver and living adamantine. You reduce your slowed condition by 1. Alternatively, if you are not slowed, you are quickened 1 during your next turn, and can use your extra action to (action: Stride) or (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fcf02cb0-5da7-4e05-bb7a-10bd9228123b"), Feats.Instances.GolemGrafterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4244b72e-7004-4574-8834-93c6c3c777b9"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
