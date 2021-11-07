using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Mobility : Template
    {
        public static readonly Guid ID = Guid.Parse("b4e65481-2960-4b66-95ac-c8c4dbf9716b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mobility",
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
            yield return new TextBlock { Id = Guid.Parse("4cc5bc1e-e7d3-45c9-bb08-dbca9766259f"), Type = TextBlockType.Text, Text = "You move in a way that denies your enemies the opportunity to retaliate. When you take a (action: Stride) action to move half your Speed or less, that movement does not trigger reactions. You can use Mobility when (action: Climbing | Climb), (action: Flying | Fly), or (action: Swimming | Swim) instead of (action: Striding | Stride) if you have the corresponding movement type." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ad5fe60-aa6e-4ab6-a8f3-88755279cf1c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
