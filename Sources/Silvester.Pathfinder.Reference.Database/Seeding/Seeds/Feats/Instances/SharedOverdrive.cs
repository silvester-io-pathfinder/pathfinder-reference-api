using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SharedOverdrive : Template
    {
        public static readonly Guid ID = Guid.Parse("7c7d1ab3-1d33-44c3-8377-c8a03cf1da08");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shared Overdrive",
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
            yield return new TextBlock { Id = Guid.Parse("cac6f984-68a1-4276-a13f-c157c6812aab"), Type = TextBlockType.Text, Text = "You’ve experimented enough on your teammates to transfer a substantial number of powered-up gizmos to them, enabling one of your allies to benefit from the full effects and duration of your (action: Overdrive). The first time you use (feat: Overdrive Ally) during a given (action: Overdrive), the effect lasts for the remainder of the duration of your (action: Overdrive), instead of just until the end of the target’s next turn. Any further uses of (feat: Overdrive Ally) during the same (action: Overdrive) have their normal duration, per (feat: Overdrive Ally)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6c8c1bcb-e726-49ab-a1bd-bcb012d0def0"), Feats.Instances.OverdriveAlly.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e2b9f00-d343-478d-ae96-cd8790a396fd"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
