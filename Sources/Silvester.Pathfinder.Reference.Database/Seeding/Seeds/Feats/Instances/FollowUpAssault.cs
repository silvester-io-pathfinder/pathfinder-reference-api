using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FollowUpAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("6726c5b8-3b13-44a0-ab24-e77ad4f968bd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Follow-Up Assault",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6c0c8658-2492-431d-9b25-8852ae765ca4"), Type = TextBlockType.Text, Text = "Even in the face of failure you press the attack, determined to succeed. Make a (action: Strike) with the same weapon, adding the effects of the (trait: backswing) and (trait: forceful) weapon traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4cfb62a9-d857-4b74-830a-e02abcd0b529"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
