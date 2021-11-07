using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Slink : Template
    {
        public static readonly Guid ID = Guid.Parse("b83e311b-844b-405e-bac0-de8491d71024");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Slink",
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
            yield return new TextBlock { Id = Guid.Parse("b0488dd0-2d56-46c2-bab2-74e0b8ebe04b"), Type = TextBlockType.Text, Text = "You can move through gloom with the speed of darkness. You can move 5 feet farther when you take the (action: Sneak) action, up to your Speed. In addition, as long as you continue to use (action: Sneak) actions and succeed at your Stealth check, you don’t become observed if you end a (action: Sneak) action in dim light or darkness, as long as you have cover or greater cover or are concealed at the end of your turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd6b23d8-c814-47ea-aea2-68d0d0c1672a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
