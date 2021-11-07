using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardingSign : Template
    {
        public static readonly Guid ID = Guid.Parse("f2f602d1-ae02-40df-b018-240c624bd558");

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
            yield return new TextBlock { Id = Guid.Parse("84c60840-7aeb-4c6c-8906-eb17e636bf2f"), Type = TextBlockType.Text, Text = "You call on the power of a personal, eldritch sign of protection, which flares brightly before slowly fading. You gain a +2 circumstance bonus to the triggering saving throw, or a +3 circumstance bonus if the effect is a (trait: curse)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fffbe6fd-f1b8-41b1-a76c-4ef33d3a7a3a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
