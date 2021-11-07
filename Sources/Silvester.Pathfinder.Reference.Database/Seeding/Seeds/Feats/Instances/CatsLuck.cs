using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatsLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("18d17f3a-5591-47eb-a384-447257a9c11b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cat's Luck",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fail a Reflex saving throw.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("766a090e-ea24-4e94-b30d-cedfcb1a2a22"), Type = TextBlockType.Text, Text = "You instinctively twist away from danger. You can reroll the triggering saving throw and use the better result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2abf8741-d4d7-41b2-b0c4-bac70079a38d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
