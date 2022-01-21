using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WornItems.Instances
{
    public class RingOfEnergyResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("869c1c1a-648f-47cd-a6c1-81d3e5cb79a3");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Ring of Energy Resistance",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("611017cc-d8ca-4931-b54f-d51f22d169ff"), "This ring grants you resistance 5 against one type of energy damage: acid, cold, electricity, fire, or sonic. Each ring is crafted to protect against a particular type of energy damage, and its design usually embodies the type of energy it protects the wearer from in some way. For instance, a ring of fire resistance might be capped with a ruby, whereas a ring of cold resistance features a sapphire instead.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5743c23c-d6ba-4c7a-84c6-95f4a55bd84b"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("300dca7b-af48-442d-a430-741a9ce9f5de"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("57a25150-20b3-46b1-97b4-ea9525155c8f"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("9a79856f-9bdd-41d7-959f-253ad61d8c30"),
                Name = "Ring of Energy Resistance",
                Usage = "Worn.",
                Level = 6,
                Price = 24500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("c8487b17-7229-4c94-86f2-53077225b369"),
                Name = "Ring of Energy Resistance (Greater)",
                Usage = "Worn.",
                Level = 10,
                Price = 97500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("2bebc8b1-c289-4033-9794-8c1a9183fd51"), "The ring grants resistance 10.")
                    .Build(),
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("f048cb31-5402-46d6-8df5-339bf413a3f2"),
                Name = "Ring of Energy Resistance (Major)",
                Usage = "Worn.",
                Level = 14,
                Price = 440000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("a3dd6106-b5cd-44e7-8e9c-66a9a1a83431"), "The ring grants resistance 15.")
                    .Build(),
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cfe0e71e-24b6-4751-96c6-7ee1733c982f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 614
            };
        }
    }
}
