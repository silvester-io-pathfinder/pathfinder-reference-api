using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OngoingInvestigation : Template
    {
        public static readonly Guid ID = Guid.Parse("e795a665-6098-408d-a4c5-062fe94b6454");

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
            yield return new TextBlock { Id = Guid.Parse("dda317b7-80e0-46b0-94ec-d086758c41cd"), Type = TextBlockType.Text, Text = "You&#39;re always investigating what&#39;s around you, even as you perform other activities. You can move at full Speed while using the (action: Investigate) exploration activity, and you can use another exploration activity while (action: Investigating | Investigate)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48396b45-4227-4b9c-a751-78181a94c777"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}