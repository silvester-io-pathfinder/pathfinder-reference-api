using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ComeAndGetMe : Template
    {
        public static readonly Guid ID = Guid.Parse("5f3f46d0-5433-4a45-8fc7-d7159ee79fd6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Come and Get Me",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32896b2e-eefa-48e3-9156-b1854ae0511a"), Type = TextBlockType.Text, Text = "You open yourself to attacks so you can respond in turn. Until your rage ends, you are flat-footed, and damage rolls against you gain a +2 circumstance bonus. If a creature hits you, that creature is flat-footed to you until the end of your next turn. If you hit it before the end of your next turn, you gain temporary Hit Points equal to your Constitution modifier, or double that on a critical hit." };
            yield return new TextBlock { Id = Guid.Parse("e7298dc3-181e-4f20-b6b2-f0a26132c732"), Type = TextBlockType.Text, Text = "These temporary Hit Points last until the end of your rage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b6728fd1-2fee-443e-b076-9105c08472da"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
