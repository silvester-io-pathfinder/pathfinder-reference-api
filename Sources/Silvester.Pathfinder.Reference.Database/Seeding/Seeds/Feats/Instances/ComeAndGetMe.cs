using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ComeAndGetMe : Template
    {
        public static readonly Guid ID = Guid.Parse("dc912bfb-b29b-4892-8356-2d3241c7d155");

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
            yield return new TextBlock { Id = Guid.Parse("653bf621-8fc2-4c75-9672-83280de8e812"), Type = TextBlockType.Text, Text = "You open yourself to attacks so you can respond in turn. Until your rage ends, you are flat-footed, and damage rolls against you gain a +2 circumstance bonus. If a creature hits you, that creature is flat-footed to you until the end of your next turn. If you hit it before the end of your next turn, you gain temporary Hit Points equal to your Constitution modifier, or double that on a critical hit." };
            yield return new TextBlock { Id = Guid.Parse("2e4d24bc-ad61-4497-b3aa-3fdb3365509f"), Type = TextBlockType.Text, Text = "These temporary Hit Points last until the end of your rage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3ca123be-ff96-40c2-951f-fb11a67d66af"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
