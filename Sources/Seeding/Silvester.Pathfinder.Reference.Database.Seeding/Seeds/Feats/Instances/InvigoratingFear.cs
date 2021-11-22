using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvigoratingFear : Template
    {
        public static readonly Guid ID = Guid.Parse("09d64ebc-b827-42a9-b800-44c161beec11");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Invigorating Fear",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within 60 feet gains the frightened condition.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b3451235-6f10-4ea4-9bab-26fd220e94b9"), Type = TextBlockType.Text, Text = "You are invigorated by the shock of a prank or the thrum of terror. You gain temporary Hit Points equal to the creature's level or 3, whichever is higher." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d870dc5f-e9cb-4fed-9dcb-94b1abbe5f83"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
