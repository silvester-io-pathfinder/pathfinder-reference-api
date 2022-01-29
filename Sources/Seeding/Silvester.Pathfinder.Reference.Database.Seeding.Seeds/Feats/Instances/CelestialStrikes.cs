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
    public class CelestialStrikes : Template
    {
        public static readonly Guid ID = Guid.Parse("8b12683a-3525-42e2-8f02-d1d4f76681e1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Celestial Strikes",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a18b3c1-96c8-4f6f-8849-6886dcf688e5"), Type = TextBlockType.Text, Text = $"Your connection to good arms all your attacks against forces of evil. All your weapon and unarmed {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} deal 1 additional good damage and have the {ToMarkdownLink<Models.Entities.Trait>("good", Traits.Instances.Good.ID)} and {ToMarkdownLink<Models.Entities.Trait>("magical", Traits.Instances.Magical.ID)} traits." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e29da3a9-0be5-4cff-9c13-32ac5377194d"), Traits.Instances.Aasimar.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf7d8126-aeb9-4b20-ad3e-65b9f5e4290d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
