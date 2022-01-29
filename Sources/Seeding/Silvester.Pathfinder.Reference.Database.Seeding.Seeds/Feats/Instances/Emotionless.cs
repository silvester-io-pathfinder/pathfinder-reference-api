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
    public class Emotionless : Template
    {
        public static readonly Guid ID = Guid.Parse("67ddf3eb-36b1-4721-ac86-8f6062fffaf2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emotionless",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0fd389e9-1315-46de-9501-956352922cea"), Type = TextBlockType.Text, Text = $"Your malfunctioning emotional processors make it difficult for you to feel strong emotions. You gain a +1 circumstance bonus to saving throws against {ToMarkdownLink<Models.Entities.Trait>("emotion", Traits.Instances.Emotion.ID)} and {ToMarkdownLink<Models.Entities.Trait>("fear", Traits.Instances.Fear.ID)} effects. If you roll a success on a saving throw against an {ToMarkdownLink<Models.Entities.Trait>("emotion", Traits.Instances.Emotion.ID)} or {ToMarkdownLink<Models.Entities.Trait>("fear", Traits.Instances.Fear.ID)} effect, you get a critical success instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Android.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea1fa980-635e-4f92-97a2-ec348e95ca93"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
