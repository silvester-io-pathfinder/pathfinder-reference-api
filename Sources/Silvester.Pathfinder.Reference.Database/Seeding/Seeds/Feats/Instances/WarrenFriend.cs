using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WarrenFriend : Template
    {
        public static readonly Guid ID = Guid.Parse("e8c745aa-1194-41c4-94f9-e01d1624f161");

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
            yield return new TextBlock { Id = Guid.Parse("b31f05e2-5805-4bb3-ba1e-ad4159d4ba2c"), Type = TextBlockType.Text, Text = "You’re adept at making contact with other ysoki. When you arrive at a new settlement, you automatically find the nearest ratfolk enclave by spending 1 day of downtime searching, provided one exists and its members aren’t actively hiding from you. Once you’ve made contact, you gain a +1 circumstance bonus to (action: Gather Information) and (action: Earn Income) in the settlement." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a65e8be-51cc-4d96-a824-2ba1fe59011f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
