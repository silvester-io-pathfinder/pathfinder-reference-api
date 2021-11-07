using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicSycophant : Template
    {
        public static readonly Guid ID = Guid.Parse("ea454fe3-614d-413e-893e-993a84c83c7e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Sycophant",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have the (feat: Glad-Hand) skill feat, you don't take the penalty to your immediate Diplomacy check if the target has the (trait: dragon) trait.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2fd5fafd-dcf7-4df2-8854-efb159a466eb"), Type = TextBlockType.Text, Text = "You have an affect that dragonkind find unusually pleasing—and when that fails, you know when to duck. You gain a +2 circumstance bonus to Perception checks and saving throws against dragons. In addition, whenever you meet a creature with the (trait: dragon) trait in a social situation, you can attempt a Diplomacy check to (action: Make an Impression) on that creature immediately, rather than after conversing for 1 minute; you take a –5 penalty to this check. If you fail, you can choose to engage in 1 minute of conversation and then attempt a new check rather than accept the failure or critical failure result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("682f8a35-b7aa-4821-a0ce-0d547f704440"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
