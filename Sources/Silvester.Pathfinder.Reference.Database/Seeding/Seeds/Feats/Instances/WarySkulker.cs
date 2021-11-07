using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WarySkulker : Template
    {
        public static readonly Guid ID = Guid.Parse("98fba331-da4e-46fb-a116-1089a11a1dde");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wary Skulker",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7dec7c3d-6a90-45b0-8ecb-8faea603cb0a"), Type = TextBlockType.Text, Text = "Ever alert, you scout for danger even when you are trying to stay hidden. You can perform the (action: Scout) exploration activity at the same time as the (action: Avoid Notice) exploration activity." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3cf936e1-3827-4a00-bf7a-b854b423812f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
