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
    public class ImposeOrder : Template
    {
        public static readonly Guid ID = Guid.Parse("e3f3cbb2-a330-40f5-94f5-b2b601977099");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impose Order",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would critically fail a skill check or suffer an effect with the misfortune trait.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("03e6a79e-cdf2-41d5-a9b5-899dd710aa98"), Type = TextBlockType.Text, Text = $"You shift the underlying fabric of reality to impose a baseline of order. If the trigger was a skill check, you instead receive a result of 10 + your proficiency bonus (don't apply any other bonuses, penalties, or modifiers). If the trigger was an effect with the {ToMarkdownLink<Models.Entities.Trait>("misfortune", Traits.Instances.Misfortune.ID)} trait, the {ToMarkdownLink<Models.Entities.Trait>("misfortune", Traits.Instances.Misfortune.ID)} and {ToMarkdownLink<Models.Entities.Trait>("fortune", Traits.Instances.Fortune.ID)} effects cancel each other out as normal, negating the triggering {ToMarkdownLink<Models.Entities.Trait>("misfortune", Traits.Instances.Misfortune.ID)} effect." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f72c311b-0a5b-448a-acbf-17a69382df1d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
