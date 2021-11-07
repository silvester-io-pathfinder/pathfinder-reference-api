using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrickstersAce : Template
    {
        public static readonly Guid ID = Guid.Parse("e3cc2b7c-391c-4293-833f-4a27e420e8a9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Trickster's Ace",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You specify the trigger when you make your daily preparations (see Requirements).",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e56c81d9-db10-4c3c-b23a-7448631b5ce0"), Type = TextBlockType.Text, Text = "Whether from jury-rigged magic items, stolen magical essence, or other means, you have a contingency in your back pocket for desperate situations. When the trigger occurs, you cause the spell to come into effect. The spell targets only you, no matter how many creatures it would affect normally. If you define particularly complicated conditions, as determined by the GM, the trigger might fail. Once the contingency is triggered, the spell is expended until your next daily preparations." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5468dd0-1d6d-4634-b7a6-bfea047f9d87"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
