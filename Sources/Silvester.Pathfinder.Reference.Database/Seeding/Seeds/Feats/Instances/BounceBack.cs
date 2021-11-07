using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BounceBack : Template
    {
        public static readonly Guid ID = Guid.Parse("e1929762-ce36-4cbb-ae16-502366dfc54b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bounce Back",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You lose the dying condition.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70e32814-6891-4b67-98b9-8bbb58794933"), Type = TextBlockType.Text, Text = "You recover from near-death experiences with astounding resilience. Don’t increase the value of your wounded condition due to losing the dying condition." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b757e67-fe51-4d2a-95d6-f628ecc5b88d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
