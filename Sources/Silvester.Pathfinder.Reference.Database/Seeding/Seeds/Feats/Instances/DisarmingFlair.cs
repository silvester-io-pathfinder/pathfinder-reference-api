using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisarmingFlair : Template
    {
        public static readonly Guid ID = Guid.Parse("3a78fd99-cf6f-4450-b0fd-2b5bd42ab0a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disarming Flair",
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
            yield return new TextBlock { Id = Guid.Parse("f321175a-e8ad-4623-b32a-3107dd8971f5"), Type = TextBlockType.Text, Text = "It’s harder for your foes to regain their grip when you knock their weapon partially out of their hands. When you succeed at an Athletics check to (action: Disarm), the circumstance bonus and penalty from (action: Disarm) last until the end of your next turn, instead of until the beginning of the target’s next turn. The target can use an (action: Interact) action to adjust their grip and remove this effect. If your swashbuckler’s style is gymnast and you succeed at your Athletics check to (action: Disarm) a foe, you gain panache." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("26f60470-fe48-4fda-b7d0-8c9def8b6dc4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
