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
    public class AnalyzeInformation : Template
    {
        public static readonly Guid ID = Guid.Parse("e18d75aa-69e4-46d7-98ea-31f74db4ed35");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Analyze Information",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3963f81d-2d86-4d86-9f61-60fe66664abf"), Type = TextBlockType.Text, Text = $"You can stoke your mind into a burst of analytical prowess. You can cast 3rd-level {ToMarkdownLink<Models.Entities.Spell>("hypercognition", Spells.Instances.Hypercognition.ID)} once per day as a divine innate spell." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Aphorite.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ae4c148-71c3-48a4-b316-c7a8a9ca6841"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
