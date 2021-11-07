using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KeenFollower : Template
    {
        public static readonly Guid ID = Guid.Parse("76282d12-c1dd-4227-bd07-ac4d44c66f59");

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
            yield return new TextBlock { Id = Guid.Parse("ba4fc3ec-c042-446a-b6a1-e76f1e26ff92"), Type = TextBlockType.Text, Text = "Your keen observation of your allies has made you better at following their lead. When using the (action: Follow the Expert) activity in exploration mode, you gain a +3 circumstance bonus if the ally you are following is an expert and a +4 circumstance bonus if your ally is a master." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16cce09c-eb98-4d71-821a-a6ff91808f82"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
