using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OngoingInvestigation : Template
    {
        public static readonly Guid ID = Guid.Parse("003fe240-e987-488e-94ae-19959451b22f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ongoing Investigation",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("06f991ee-3001-4bfc-9bab-17a15186842e"), Type = TextBlockType.Text, Text = "You&#39;re always investigating what&#39;s around you, even as you perform other activities. You can move at full Speed while using the (action: Investigate) exploration activity, and you can use another exploration activity while (action: Investigating | Investigate)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a92592c5-1091-4b5f-a128-c92a456040e1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
