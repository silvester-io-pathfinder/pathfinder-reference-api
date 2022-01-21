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
    public class Clothing : Template
    {
        public static readonly Guid ID = Guid.Parse("727c9745-f0dd-4c3d-b76f-ae806792d762");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Clothing",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b2549e98-5706-4d62-bc51-0fb39f4d4acd"),
                Name = "Clothing (Ordinary)",
                Level = 0,
                Price = 10,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("f80d61d1-ceb6-426b-89ee-8daed0b8e91b"), "Ordinary clothing is functional with basic tailoring, such as peasant garb, monk�s robes, or work clothes.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("049b9e51-c47c-4c19-a731-5f9870b6bbd3"),
                Name = "Clothing (Explorer's)",
                Level = 0,
                Price = 10,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("2ba499f8-ac2c-4a13-ad89-f1c5d6e517fe"), "Explorer's clothing is sturdy enough that it can be reinforced to protect you, even though it isn't a suit of armor. It comes in many forms, though the most common sorts look like clerical vestments, monk's garments, or wizard's robes, as members of all three classes are likely to avoid wearing armor. For more information on explorer's clothing, see its entry in the armor category.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("8ef0365d-06c3-4dee-8a95-969554e85466"),
                Name = "Clothing (Fine)",
                Level = 0,
                Price = 200,
                Hands = "0",
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("5caa021a-26fe-432b-bb59-ca89a123c74a"), "Fine clothing, suitable for a noble or royal, is made with expensive fabrics, precious metals, and intricate patterns. You can wear only one tool set of light Bulk with fine clothing, instead of the normal limit of 2 Bulk.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("647baa6b-6932-45e7-bf06-e49d5770c68e"),
                Name = "Clothing (High-Fashion Fine)",
                Level = 3,
                Price = 5500,
                Hands = "0",
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("5132adfc-fd3c-4798-b302-af75d9ea361a"), "You gain a +1 item bonus to checks to Make an Impression on upper-class folk while wearing high-fashion fine clothing.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("6c3264fe-5dc2-495a-b742-27a5d5757c52"),
                Name = "Clothing (Winter)",
                Level = 0,
                Price = 40,
                Hands = "0",
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("1d9b108f-a682-49df-a154-de0e270e0fef"), "Winter clothing allows you to negate the damage from severe environmental cold and reduce the damage from extreme cold to that of severe cold.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("66115a16-38f5-4728-ae03-e4d1a17809d4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 287
            };
        }
    }
}
