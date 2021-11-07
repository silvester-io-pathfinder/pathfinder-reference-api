using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CheekPouches : Template
    {
        public static readonly Guid ID = Guid.Parse("a2046526-90a3-4c63-bee8-8cb73119b4e2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cheek Pouches",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c978f476-9863-448a-8512-f91958b23e7d"), Type = TextBlockType.Text, Text = "Your cheeks are stretchy, and you can store up to four items of light Bulk or less in these cheek pouches. None of these items can have a dimension longer than 1 foot. As long as you have at least one item in your cheek pouches, your speech is noticeably difficult to understand. Placing an item in your cheek pouch or retrieving one is an (action: Interact) action. You can empty your mouth with a single action, causing everything you had stored in your cheek pouches to fall to the ground in your square." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3cba1fa5-43c9-46c4-a718-8d4a2935fdb4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
