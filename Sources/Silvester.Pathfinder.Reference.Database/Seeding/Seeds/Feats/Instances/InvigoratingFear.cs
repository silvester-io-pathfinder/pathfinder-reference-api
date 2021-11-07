using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvigoratingFear : Template
    {
        public static readonly Guid ID = Guid.Parse("72a34ceb-3967-4868-a0b9-5785e9e42092");

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
            yield return new TextBlock { Id = Guid.Parse("4b4c5bd7-bb58-46b0-92e1-e34aab79689f"), Type = TextBlockType.Text, Text = "You are invigorated by the shock of a prank or the thrum of terror. You gain temporary Hit Points equal to the creature&#39;s level or 3, whichever is higher." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("674e8d2e-66cb-4150-b2b9-943abca47ea4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
