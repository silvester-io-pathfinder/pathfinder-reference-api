using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MobileFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("33f37827-180f-4745-a619-ad9d4e9bec5a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mobile Finisher",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2ae7aa5d-65f5-4aea-834f-6e165865c600"), Type = TextBlockType.Text, Text = "You attack in motion. (action: Stride) and then (action: Strike). You can use Mobile Finisher while (action: Burrowing | Burrow), (action: Climbing | Climb), (action: Flying | Fly), or (action: Swimming | Swim) instead of (action: Striding | Stride) if you have the corresponding movement type." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b8f129d-3608-49c7-98d3-1af6bca110d0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
