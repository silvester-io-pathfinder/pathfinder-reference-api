using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Antagonize : Template
    {
        public static readonly Guid ID = Guid.Parse("e3bf0b11-0488-48c5-b1b3-a8c1f4f2b5e3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Antagonize",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1508d428-1362-4c00-8692-e59e0b8e7ef7"), Type = TextBlockType.Text, Text = "Your taunts and threats earn your foes ire. When you successfully (action: Demoralize) a creature, its frightened condition can’t decrease to less than 1 at the end of its turn until it either uses a hostile action against you or can no longer observe or sense you for at least 1 round." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f37b55b6-8f61-4d8f-a400-773b6aaf8626"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
