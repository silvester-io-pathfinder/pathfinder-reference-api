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
    public class Ready : Template
    {
        public static readonly Guid ID = Guid.Parse("2dcf90ee-e52e-4e69-a809-6790cf49a622");

        public static readonly Guid STANDARD_ID = Guid.Parse("7e0e2fe0-a05e-45b8-bc1f-f1792e1ffc11");
        public static readonly Guid GREATER_ID = Guid.Parse("939ada90-fd7e-487d-9838-5eb1412fa98d");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Ready",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9b5141e5-b893-4888-9173-33d15860de6c"), "A ready rune draws component pieces of a suit of armor toward one another, making it easier and faster to get into.");;
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Ready",
                Usage = "Etched onto armor.",
                Level = 6,
                Price = 20000,
                PotencyId = Potencies.Instances.Standard.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("82f44d2c-d6da-4382-b805-8626b2fdb937"), "You can don light armor with this rune as a 3-action activity or medium or heavy armor with this rune in 1 minute.")
					.Build(),
            };

            yield return new ArmorPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Ready (Greater)",
                Usage = "Etched onto armor.",
                Level = 11,
                Price = 120000,
                PotencyId = Potencies.Instances.Greater.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("482a2190-dfe0-45dc-adb3-e06339201730"), "You can don light armor with a greater ready rune as a single action, or medium or heavy armor with a greater ready rune as a 3-action activity.")
					.Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b710191a-3e46-4876-aac2-12906b34daf1"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("5dbd9fc7-26c2-4de2-ac5b-79e1bce3ab84"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08f3aeac-81ce-4aa5-a0cb-47b5535a7619"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 262
            };
        }

    }
}
