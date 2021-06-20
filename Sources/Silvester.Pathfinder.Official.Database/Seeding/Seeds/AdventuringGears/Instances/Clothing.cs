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
    public class Clothing : Template
    {
        public static readonly Guid ID = Guid.Parse("727c9745-f0dd-4c3d-b76f-ae806792d762");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Ordinary Clothing",
                Hands = "0",
                Price = 10,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("167bcff2-2a0d-4a34-acce-b5597857fc87"), Type = TextBlockType.Text, Text = "Ordinary clothing is functional with basic tailoring, such as peasant garb, monk’s robes, or work clothes." };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("049b9e51-c47c-4c19-a731-5f9870b6bbd3"),
                NameAddendum = "Explorer's",
                DescriptionAddendum = "Explorer’s clothing is sturdy enough that it can be reinforced to protect you, even though it isn’t a suit of armor. It comes in many forms, though the most common sorts look like clerical vestments, monk’s garments, or wizard’s robes, as members of all three classes are likely to avoid wearing armor. For more information on explorer’s clothing, see its entry in the armor category.",
                ItemLevel = 0,
                Price = 10,
                Hands = 0,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("8ef0365d-06c3-4dee-8a95-969554e85466"),
                NameAddendum = "Fine",
                DescriptionAddendum = "Fine clothing, suitable for a noble or royal, is made with expensive fabrics, precious metals, and intricate patterns. You can wear only one tool set of light Bulk with fine clothing, instead of the normal limit of 2 Bulk.",
                ItemLevel = 0,
                Price = 200,
                Hands = 0,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("647baa6b-6932-45e7-bf06-e49d5770c68e"),
                NameAddendum = "High-Fashion Fine",
                DescriptionAddendum = "You gain a +1 item bonus to checks to Make an Impression on upper-class folk while wearing high-fashion fine clothing.",
                ItemLevel = 3,
                Price = 5500,
                Hands = 0,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("6c3264fe-5dc2-495a-b742-27a5d5757c52"),
                NameAddendum = "Winter",
                DescriptionAddendum = "Winter clothing allows you to negate the damage from severe environmental cold and reduce the damage from extreme cold to that of severe cold.",
                ItemLevel = 0,
                Price = 40,
                Hands = 0,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("66115a16-38f5-4728-ae03-e4d1a17809d4"),
                SourceId = CoreRulebook.ID,
                Page = 287
            };
        }
    }
}
