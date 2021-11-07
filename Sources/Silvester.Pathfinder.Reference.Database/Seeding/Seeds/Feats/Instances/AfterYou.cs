using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AfterYou : Template
    {
        public static readonly Guid ID = Guid.Parse("335c7931-b0cc-4f49-860d-c2b132d13e36");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "After You",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You're about to roll initiative.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3bbe9e45-08a6-49c3-a9df-f618b2f14b28"), Type = TextBlockType.Text, Text = "You allow your foes to make the first move in a show of incredible confidence. You don’t roll initiative; instead you voluntarily go last. You gain panache. If more than one character uses this ability or another ability to go last, use the normal rules for resolving a tie: NPCs and monsters act before PCs, and within those groups, the creatures can choose whichever order they want." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("097442f1-bdc0-402b-bf2f-e33410c4d31f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
