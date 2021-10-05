using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class PlayingCards : Template
    {
        public static readonly Guid ID = Guid.Parse("64de129b-3287-4f24-b01a-b50c5a2123be");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Playing Cards",
                Hands = "2",
                Price = 50,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9613ef6a-8da8-42bf-82b2-4e37e8accba0"), Type = TextBlockType.Text, Text = "A standard deck of cards consists of 54 cards made from thick paper contained within a paper sleeve. The most common deck used for games and gambling is known as the Old Mage deck and features four suits themed with the four essences of magic, each with 13 cards, as well as two wildcards. The name and appearance of the deck varies from region to region, such as the Magician's Deck in Taldor or the Deck of Masks in the Shackles." };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("50ccb809-38cd-4618-aaa6-dd12cef309a0"),
                NameAddendum = "Marked",
                DescriptionAddendum = "A deck of marked playing cards appears to be an ordinary deck upon initial inspection but bears specific folds, colors, scratches, or other markings on each card that allow an informed user to know what's on the other side of a card. A deck of marked cards grants you a +1 item bonus to Games Lore checks or other relevant checks to gamble with the cards. You can determine that an unattended deck of cards is marked with a successful DC 20 Perception check. Determining that a deck is marked during play is more difficult and is typically determined by a Perception check against the dealer's Games Lore or Thievery DC.",
                ItemLevel = 0,
                Price = 100,
                Hands = 2,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ff474cb-42fd-4456-809d-5ea4aac492cf"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 115
            };
        }
    }
}
