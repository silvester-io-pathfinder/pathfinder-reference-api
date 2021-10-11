using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Special
{
    public class WardingSignFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("c8efb0e0-df69-40b9-94b8-b7e7f07a02c4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warding Sign",
                Level = 1,
                Frequency = "Once per minute.", 
                Trigger = "You attempt a saving throw against a magical effect, but you haven't rolled yet.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("12641bdc-b491-47bd-acfa-afc1923659ac"), Type = TextBlockType.Text, Text = "You call on the power of a personal, eldritch sign of protection, which flares brightly before slowly fading. You gain a +2 circumstance bonus to the triggering saving throw, or a +3 circumstance bonus if the effect is a curse." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aae9424b-07cc-4e9d-94c5-cbe3b08bef30"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 50
            };
        }
    }
}
