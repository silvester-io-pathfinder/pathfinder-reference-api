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
    public class WellVersed : Template
    {
        public static readonly Guid ID = Guid.Parse("94e5d66c-feff-4a28-ae11-da6b53ad5a9e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Well-Versed",
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
            yield return new TextBlock { Id = Guid.Parse("04e276c0-9a04-436e-b10d-a0e38cb49a4e"), Type = TextBlockType.Text, Text = $"You're resilient to performative influences that aren't your own. You gain a +1 circumstance bonus to saving throws against effects with the {ToMarkdownLink<Models.Entities.Trait>("auditory", Traits.Instances.Auditory.ID)}, {ToMarkdownLink<Models.Entities.Trait>("illusion", Traits.Instances.Illusion.ID)}, {ToMarkdownLink<Models.Entities.Trait>("linguistic", Traits.Instances.Linguistic.ID)}, {ToMarkdownLink<Models.Entities.Trait>("sonic", Traits.Instances.Sonic.ID)}, or {ToMarkdownLink<Models.Entities.Trait>("visual", Traits.Instances.Visual.ID)} traits." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d571810e-0eee-4575-8627-ca5e2efeb6fd"), Traits.Instances.Bard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3abdd2b7-e679-4b55-a819-c5816f3f7e27"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
