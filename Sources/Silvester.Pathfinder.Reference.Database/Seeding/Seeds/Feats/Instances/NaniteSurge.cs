using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NaniteSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("d5cc4544-cc0c-4b53-bd54-7596cc6c6daa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nanite Surge",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a skill check requiring three actions or fewer.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("098c7f1a-8064-44e2-b5f5-e6b9f336d0c0"), Type = TextBlockType.Text, Text = "You stimulate your nanites, forcing your body to temporarily increase its efficiency. You gain a +2 status bonus to the triggering skill check. In addition, your circuitry glows, lighting a 10-foot emanation with dim light for 1 round." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7d8a09f8-29de-462a-8865-ddd7fca85cac"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
