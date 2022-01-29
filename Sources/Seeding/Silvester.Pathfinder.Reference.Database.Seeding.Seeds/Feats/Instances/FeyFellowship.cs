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
    public class FeyFellowship : Template
    {
        public static readonly Guid ID = Guid.Parse("8a6fd1ae-cec1-480a-a577-3675eee7ccd1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fey Fellowship",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have the Glad-Hand skill feat, you don't take the penalty on your immediate Diplomacy check if the target is a fey.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("86adab52-af75-4a13-9783-c27d21f81ff6"), Type = TextBlockType.Text, Text = $"Your enhanced fey connection affords you a warmer reception from creatures of the First World as well as tools to foil their tricks. You gain a +2 circumstance bonus to both Perception checks and saving throws against fey." };
            yield return new TextBlock { Id = Guid.Parse("9fe3ef88-8fb5-4d9f-a07b-ad529148227e"), Type = TextBlockType.Text, Text = $"In addition, whenever you meet a fey creature in a social situation, you can immediately attempt a Diplomacy check to {ToMarkdownLink<Models.Entities.SkillAction>("Make an Impression", SkillActions.Instances.MakeAnImpression.ID)} on that creature rather than needing to converse for 1 minute. You take a -5 penalty to the check. If you fail, you can engage in 1 minute of conversation and attempt a new check at the end of that time rather than accepting the failure or critical failure result." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Gnome.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3229a86e-ef23-415a-bf8b-e3d3b3dce427"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
