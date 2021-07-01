using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
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
                Hands = "2",
                Price = 100,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("de573077-4fef-43d7-aee3-47bb47fd275c"),
                NameAddendum = "Common",
                ItemLevel = 0,
                Price = 100,
                Hands = 2,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("0d267810-983b-454d-8252-90bdf15be28d"),
                NameAddendum = "Simple",
                ItemLevel = 0,
                Price = 1000,
                Hands = 2,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("cad66a2f-ec44-49ad-a5e1-6368f2485b94"),
                NameAddendum = "Fine",
                ItemLevel = 0,
                Price = 1100,
                Hands = 2,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("909f1c28-5412-4c02-ab01-e3b604adb323"), Type = TextBlockType.Text, Text = "Used by gamblers and seers alike, this deck of cards comes in several varieties. Simple harrow decks are made from low-quality paper and typically have only an icon and a number to signify the suit and alignment. These simple decks are mostly used for games of chance, as the actual image and significance of the cards are irrelevant for such games." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6240d00f-37a0-43a5-8b6c-7797e00372a7"),
                SourceId = Pathfinder160.ID,
                Page = 66
            };
        }
    }
}
