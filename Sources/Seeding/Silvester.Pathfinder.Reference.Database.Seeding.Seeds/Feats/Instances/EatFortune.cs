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
    public class EatFortune : Template
    {
        public static readonly Guid ID = Guid.Parse("39637619-d0df-4be3-bd17-4a4fed90d64f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eat Fortune",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within 60 feet uses a fortune or misfortune effect.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ed23c4ec-ba99-4c6a-bfb2-64b734ac3bdc"), Type = TextBlockType.Text, Text = $"As someone tries to twist fate, you consume the interference. The triggering effect is disrupted. If it's a {ToMarkdownLink<Models.Entities.Trait>("misfortune", Traits.Instances.Misfortune.ID)} effect, Eat Fortune gains the {ToMarkdownLink<Models.Entities.Trait>("fortune", Traits.Instances.Fortune.ID)} trait; if it's a {ToMarkdownLink<Models.Entities.Trait>("fortune", Traits.Instances.Fortune.ID)} effect, Eat Fortune gains the {ToMarkdownLink<Models.Entities.Trait>("misfortune", Traits.Instances.Misfortune.ID)} trait. This fortune or misfortune applies to the same roll the triggering effect would have, so you couldn't negate a {ToMarkdownLink<Models.Entities.Trait>("fortune", Traits.Instances.Fortune.ID)} effect with Eat Fortune and then apply a {ToMarkdownLink<Models.Entities.Trait>("misfortune", Traits.Instances.Misfortune.ID)} effect to the same roll." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("8a348ec6-3a91-4245-915e-32d7b789cc07"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("311c44c4-7ab0-4fb2-992c-e7e311f83605"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("b65be83c-f651-4929-9bc4-f087d99d6f2e"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("d24df344-4cff-461f-a6d5-bf7a0d7c96a0"), Traits.Instances.Tengu.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b0f7759-b9af-4d74-83b5-1ffe2996fc62"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
