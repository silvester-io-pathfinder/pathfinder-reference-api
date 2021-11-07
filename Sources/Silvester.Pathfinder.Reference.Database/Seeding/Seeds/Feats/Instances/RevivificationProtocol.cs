using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RevivificationProtocol : Template
    {
        public static readonly Guid ID = Guid.Parse("554c70ae-29c4-4c47-8cfb-0f47e38fc945");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Revivification Protocol",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You have the dying condition and are about to attempt a recovery check.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b539ce60-c75b-4619-b55a-63a926a1df8a"), Type = TextBlockType.Text, Text = "Your nanites are programmed to automatically revive you. You’re restored to 1 Hit Point, lose the dying and unconscious conditions, and can act normally on this turn. You gain or increase the wounded condition as normal when losing the dying condition in this way." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6fe2a65-1bb7-492a-83cc-462093aceba3"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
