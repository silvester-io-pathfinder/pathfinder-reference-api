using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardingSign : Template
    {
        public static readonly Guid ID = Guid.Parse("43ba0c8b-4c49-47d5-9d31-6fb963446cbf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warding Sign",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a saving throw against a magical effect, but you haven't rolled yet.",
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b5725b2e-2400-4c57-a137-e1afa1eb4e19"), Type = TextBlockType.Text, Text = $"You call on the power of a personal, eldritch sign of protection, which flares brightly before slowly fading. You gain a +2 circumstance bonus to the triggering saving throw, or a +3 circumstance bonus if the effect is a {ToMarkdownLink<Models.Entities.Trait>("curse", Traits.Instances.Curse.ID)}." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68283425-2531-4e26-a664-8736f61c4b01"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
