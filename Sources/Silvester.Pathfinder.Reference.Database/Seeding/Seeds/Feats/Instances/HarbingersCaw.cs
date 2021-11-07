using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HarbingersCaw : Template
    {
        public static readonly Guid ID = Guid.Parse("7ac199b6-eb84-4ed5-ab43-d886e7934bd7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Harbinger's Caw",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within 60 feet is about to attempt an attack roll or skill check.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("528c4ed2-97ac-4103-ad61-118af14db66b"), Type = TextBlockType.Text, Text = "You caw ominously, cursing the creature with misfortune. The target creature must roll the triggering check twice and take the lower result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d4bce520-23c0-45a9-b0f3-024a9ebfc5b2"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
