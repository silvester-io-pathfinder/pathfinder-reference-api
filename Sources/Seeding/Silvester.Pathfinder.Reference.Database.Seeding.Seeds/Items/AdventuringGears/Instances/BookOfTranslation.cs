using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class BookOfTranslation : Template
    {
        public static readonly Guid ID = Guid.Parse("6f3dd7dc-f4b6-4425-b6bb-97775aeeabda");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Book of Translation",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e335ff59-4f92-405d-b0b1-5a6bafb68bc8"), "The book is leather-bound and decorated with the symbol of the Lantern Lodge. Red and gold cords wrap around the book and tie to keep it shut. Each volume offers translation for a different language. When working with a book of translation, you can attempt Diplomacy checks to Gather Information or to Make an Impression with creatures that speak the language featured in the book, even if you do not speak the language. Such checks take 10 times longer to complete and you take a –2 circumstance penalty to the check due to your limited communication capabilities.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("fb794f16-6056-404a-9685-03d081ed0066"),
                Name = "Book of Translation (Standard)",
                Level = 2,
                Price = 2500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("999126f4-74e7-45f8-ac87-7e200308cb6d"),
                Name = "Book of Translations (Advanced)",
                Level = 5,
                Price = 12500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("2d10c937-4a24-48dc-a118-1085389398ba"), "An advanced book of translation features more complex phrases, local colloquialisms, and assumes a rudimentary understanding of the featured language. Checks attempted while using an advanced book of translation do not take a circumstance penalty.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f08b7fc-8ddc-4689-95fd-9c2fd0d298ba"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 93
            };
        }
    }
}
