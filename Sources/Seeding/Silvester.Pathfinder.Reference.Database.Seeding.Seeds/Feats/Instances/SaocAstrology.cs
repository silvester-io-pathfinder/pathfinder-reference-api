using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SaocAstrology : Template
    {
        public static readonly Guid ID = Guid.Parse("67b26fbb-4b6b-44bf-872b-e8bb18b73dff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Saoc Astrology",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "3 times per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d57e0288-0552-4e93-b877-50a5cd7a9a4b"), Type = TextBlockType.Text, Text = "~ Access: Lirgeni nationality" };
            yield return new TextBlock { Id = Guid.Parse("a5b593a1-a86e-4d42-bffa-95d41722cae1"), Type = TextBlockType.Text, Text = "The ancient Saoc Brethren were the masters of astrology, and while your knowledge may be but a pale shadow of their wisdom, it still comes in handy. You recall the stars' predictions about your current situation. If your next action requires you to attempt one or more skill checks, roll 1d8. On a result of 6, 7, or 8, you gain a +2 circumstance bonus to the first such skill check you attempt. On a 3, 4, or 5, you gain a +1 circumstance bonus. On a 2, you gain nothing. On a 1, you take a -1 circumstance penalty to the skill check." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3ae8617e-ce5a-42d8-aadd-f030817df3ed"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
