using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ParagonsGuard : Template
    {
        public static readonly Guid ID = Guid.Parse("1d24f8d6-4d9c-460a-81cd-7413dbade830");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Paragon's Guard",
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
            yield return new TextBlock { Id = Guid.Parse("e6d638b1-39c8-4c23-b94b-811cf85e1807"), Type = TextBlockType.Text, Text = "Once you’ve had a moment to set your stance, you always have your shield ready without a thought. While you are in this stance, you constantly have your shield raised as if you’d used the (Action: Raise a Shield) action, as long as you meet that action’s requirements." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a95cda13-2ab4-45a9-82d3-763acb3015ff"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
