using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DevilsAdvocate : Template
    {
        public static readonly Guid ID = Guid.Parse("0fe820c2-57f3-4d8f-a078-7f921262624e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Devil's Advocate",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have the (feat: Glad-Hand) skill feat, you don't take the penalty to your immediate Diplomacy check if the target is a devil.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("efda61ac-dbb4-4fcf-af0c-740e1798569f"), Type = TextBlockType.Text, Text = $"~ Access: Chelaxian nationality" };
            yield return new TextBlock { Id = Guid.Parse("92cab9cc-22a0-48a4-b0b8-f1a5739cdd3b"), Type = TextBlockType.Text, Text = $"You know more about the habits of devils than is entirely safe. You gain a +2 circumstance bonus to Perception checks against devils and saving throws against their abilities. In addition, whenever you meet a devil in a social situation, you can immediately attempt a Diplomacy check to {ToMarkdownLink<Models.Entities.SkillAction>("Make an Impression", SkillActions.Instances.MakeAnImpression.ID)} on that creature rather than needing to converse for 1 minute. You take a -5 penalty to the check. If you fail, you can engage in 1 minute of conversation and attempt a new check at the end of that time rather than accepting the failure or critical failure result." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3d0859b-faea-4545-9c66-9a21265114fb"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
