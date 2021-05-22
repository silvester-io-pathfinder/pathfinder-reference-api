using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
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
                Hands = "0",
                ItemLevel = "2",
                Price = 2500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("999126f4-74e7-45f8-ac87-7e200308cb6d"),
                NameAddendum = "Advanced",
                DescriptionAddendum = "A mariner's astrolabe contains additional stabilizers that make it suitable for use on moving surfaces, such as the deck of a ship.",
                ItemLevel = 5,
                Price = 5000,
                Hands = 0,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e335ff59-4f92-405d-b0b1-5a6bafb68bc8"), Type = TextBlockType.Text, Text = "The book is leather-bound and decorated with the symbol of the Lantern Lodge. Red and gold cords wrap around the book and tie to keep it shut. Each volume offers translation for a different language. When working with a book of translation, you can attempt Diplomacy checks to Gather Information or to Make an Impression with creatures that speak the language featured in the book, even if you do not speak the language. Such checks take 10 times longer to complete and you take a –2 circumstance penalty to the check due to your limited communication capabilities." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f08b7fc-8ddc-4689-95fd-9c2fd0d298ba"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 93
            };
        }
    }
}
