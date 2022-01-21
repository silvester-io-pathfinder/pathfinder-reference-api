using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KeenFollower : Template
    {
        public static readonly Guid ID = Guid.Parse("bc4221e4-f8ba-4399-bbcb-805a67541999");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Keen Follower",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa1cc9f7-5d12-449d-8a3b-3a68d6661b04"), Type = TextBlockType.Text, Text = "Your keen observation of your allies has made you better at following their lead. When using the (action: Follow the Expert) activity in exploration mode, you gain a +3 circumstance bonus if the ally you are following is an expert and a +4 circumstance bonus if your ally is a master." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("512d3da4-9d0d-4220-aef0-999f1206031d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
