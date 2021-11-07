using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrickstersAce : Template
    {
        public static readonly Guid ID = Guid.Parse("92755204-fb0e-48f4-ace8-456909e53d5d");

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
            yield return new TextBlock { Id = Guid.Parse("571d9171-c703-4f4c-9400-54a5e0efbf99"), Type = TextBlockType.Text, Text = "Whether from jury-rigged magic items, stolen magical essence, or other means, you have a contingency in your back pocket for desperate situations. When the trigger occurs, you cause the spell to come into effect. The spell targets only you, no matter how many creatures it would affect normally. If you define particularly complicated conditions, as determined by the GM, the trigger might fail. Once the contingency is triggered, the spell is expended until your next daily preparations." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72a78d52-ae2f-4d77-9f71-d02a556fad8e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
