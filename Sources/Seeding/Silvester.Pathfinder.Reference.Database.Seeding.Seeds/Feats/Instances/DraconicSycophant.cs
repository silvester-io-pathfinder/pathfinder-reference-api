using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicSycophant : Template
    {
        public static readonly Guid ID = Guid.Parse("09c6ea1b-e60b-41be-92ae-8f6c7cf6ea01");

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
            yield return new TextBlock { Id = Guid.Parse("dbec23ac-5815-4d4d-af0f-3d124c3d3fe0"), Type = TextBlockType.Text, Text = $"You have an affect that dragonkind find unusually pleasing—and when that fails, you know when to duck. You gain a +2 circumstance bonus to Perception checks and saving throws against dragons. In addition, whenever you meet a creature with the {ToMarkdownLink<Models.Entities.Trait>("dragon", Traits.Instances.Dragon.ID)} trait in a social situation, you can attempt a Diplomacy check to {ToMarkdownLink<Models.Entities.SkillAction>("Make an Impression", SkillActions.Instances.MakeAnImpression.ID)} on that creature immediately, rather than after conversing for 1 minute; you take a –5 penalty to this check. If you fail, you can choose to engage in 1 minute of conversation and then attempt a new check rather than accept the failure or critical failure result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d3a650b-9f28-4ae7-9461-45cab2ca9eac"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
