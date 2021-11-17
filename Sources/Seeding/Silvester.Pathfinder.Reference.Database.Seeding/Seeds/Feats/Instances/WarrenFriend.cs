using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WarrenFriend : Template
    {
        public static readonly Guid ID = Guid.Parse("c4999262-811f-4dc2-8ee3-bee5258d5aee");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warren Friend",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bfcba6b7-e85e-4f6f-908e-e55de7702298"), Type = TextBlockType.Text, Text = "You’re adept at making contact with other ysoki. When you arrive at a new settlement, you automatically find the nearest ratfolk enclave by spending 1 day of downtime searching, provided one exists and its members aren’t actively hiding from you. Once you’ve made contact, you gain a +1 circumstance bonus to (action: Gather Information) and (action: Earn Income) in the settlement." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("acb1b7f1-92b9-4f8f-8ebc-814aa898d7b8"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
