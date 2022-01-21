using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.ArmorPropertyRunes.Instances
{
    public class Dread : Template
    {
        public static readonly Guid ID = Guid.Parse("5069cb7a-32d2-4fc4-973b-14eebb8dbff3");
        public static readonly Guid LESSER_ID = Guid.Parse("696b6be5-001a-4713-8c54-296cbd497a91");
        public static readonly Guid MODERATE_ID = Guid.Parse("f0dfebff-8b41-429f-82ba-6709721583f4");
        public static readonly Guid GREATER_ID = Guid.Parse("77b3032b-0912-4811-ba40-133309a87836");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Dread",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a88f52a7-7393-4d58-8cb9-e4a0e65eae53"), "Eerie symbols cover your armor, inspiring terror in your foes.");
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = LESSER_ID,
                Name = "Dread (Lesser)",
                Usage = "Etched onto armor.",
                Level = 6,
                Price = 22500,
                PotencyId = Potencies.Instances.Lesser.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("04297df8-ebfc-4c51-9f94-32d23594a01b"), "Frightened enemies within 30 feet that can see you must attempt a DC 20 Will save at the end of their turn; on a failure, the value of their frightened condition doesn't decrease below 1 that turn.")
                    .Build(),
            };

            yield return new ArmorPropertyRuneVariant
            {
                Id = MODERATE_ID,
                Name = "Dread (Moderate)",
                Usage = "Etched onto armor.",
                Level = 12,
                Price = 180000,
                PotencyId = Potencies.Instances.Moderate.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("a4cc0197-37b0-42e4-b329-4082450770cc"), "Frightened enemies within 30 feet that can see you must attempt a DC 29 Will save at the end of their turn; on a failure, the value of their frightened condition doesn't decrease below 2 that turn.")
                    .Build(),
            };

            yield return new ArmorPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Dread (Greater)",
                Usage = "Etched onto armor.",
                Level = 18,
                Price = 2100000,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("a49b6c8c-fe7c-4450-921b-01993be7cd53"), "Frightened enemies within 30 feet that can see you must attempt a DC 38 Will save at the end of their turn; on a failure, the value of their frightened condition doesn't decrease, no matter the value.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("1256b752-1127-4138-9219-fa5518be070c"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("88032827-e311-432c-a4f3-537eea0eb2c4"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("12e68eb0-c54d-47ed-8589-f8e897c0ae51"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("d29bc0ba-7b33-41b6-b4ca-561d46bd7ae0"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("6d3f5fcf-d9ee-40ea-a09a-c66c356dc219"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("18c9fc98-88fc-4065-a218-7fe09a73fc15"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f2b3426-4fbf-47f1-aa35-1855383fd1a5"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 14
            };
        }
    }
}
