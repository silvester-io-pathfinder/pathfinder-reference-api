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
    public class GrandScrollEsoterica : Template
    {
        public static readonly Guid ID = Guid.Parse("0054640e-74af-4c0d-a3df-50a8a1257152");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grand Scroll Esoterica",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("52d797e8-2b8e-4d54-8985-1406099cf80f"), Type = TextBlockType.Text, Text = $"You've completed the third and final step in your assimilation of scroll esoterica, granting you daily scrolls of incredible power. In addition to your daily scrolls from {ToMarkdownLink<Models.Entities.Feat>("Scroll Esoterica", Feats.Instances.ScrollEsoterica.ID)} and {ToMarkdownLink<Models.Entities.Feat>("Elaborate Scroll Esoterica", Feats.Instances.ElaborateScrollEsoterica.ID)}, add a single scroll with a 6th-level spell. At 20th level, add a scroll with a 7th-level spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f9dc9d87-e565-40a6-b660-5b4b0a41c451"), Feats.Instances.ElaborateScrollEsoterica.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91e96fec-eb5d-4a05-8ed2-3cb87a34be62"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
