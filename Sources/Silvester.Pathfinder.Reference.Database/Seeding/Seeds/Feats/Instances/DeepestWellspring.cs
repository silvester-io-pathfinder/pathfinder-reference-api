using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeepestWellspring : Template
    {
        public static readonly Guid ID = Guid.Parse("cfa743e0-7cfe-49b3-bf9f-9aa72e415a93");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deepest Wellspring",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1fa8424f-06c5-45cf-a701-e3129821866e"), Type = TextBlockType.Text, Text = "You’ve traveled to the furthest depths of your subconscious, granting you even more focus. Increase the number of Focus Points in your focus pool by 1. If you’ve spent at least 3 Focus Points since the last time you (action: Refocused | Refocus), you recover 3 Focus Points when you (action: Refocus) instead of 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f89f6e98-2b84-48e7-bc2f-1d443a9c702a"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
