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
    public class HarrowDeck : Template
    {
        public static readonly Guid ID = Guid.Parse("0674b7e7-35f2-4d29-96b6-c98ad8f99422");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Harrow Deck",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("909f1c28-5412-4c02-ab01-e3b604adb323"), "Used by gamblers and seers alike, this deck of cards comes in several varieties. Simple harrow decks are made from low-quality paper and typically have only an icon and a number to signify the suit and alignment. These simple decks are mostly used for games of chance, as the actual image and significance of the cards are irrelevant for such games.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("de573077-4fef-43d7-aee3-47bb47fd275c"),
                Name = "Harrow Deck (Common)",
                Hands = "2", 
                Level = 0,
                Price = 100,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("0d267810-983b-454d-8252-90bdf15be28d"),
                Name = "Harrow Deck (Simple)",
                Hands = "2", 
                Level = 0,
                Price = 1000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("cad66a2f-ec44-49ad-a5e1-6368f2485b94"),
                Name = "Harrow Deck (Fine)",
                Hands = "2", 
                Level = 0,
                Price = 1100,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6240d00f-37a0-43a5-8b6c-7797e00372a7"),
                SourceId = Sources.Instances.Pathfinder160.ID,
                Page = 66
            };
        }
    }
}
