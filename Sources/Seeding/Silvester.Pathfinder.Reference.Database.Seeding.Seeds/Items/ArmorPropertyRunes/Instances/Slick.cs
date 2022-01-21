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
    public class Slick : Template
    {
        public static readonly Guid ID = Guid.Parse("42cd3663-a683-4549-90f5-8d5d24195060");

        public static readonly Guid STANDARD_ID = Guid.Parse("ce68539b-be99-45c2-b16d-65df7d390fe5");
        public static readonly Guid GREATER_ID = Guid.Parse("b7c7d5c6-20b0-4ef0-803f-f8ba775d350b");
        public static readonly Guid MAJOR_ID = Guid.Parse("65dbe0f1-8a2a-434b-a96c-725df73e7ef0");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Slick",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("425f1a21-6e3b-4422-8ba5-a4011936a40f"), "This property makes armor slippery, as though it were coated with a thin film of oil.");;
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Slick",
                Usage = "Etched onto armor.",
                Level = 5,
                Price = 4500,
                PotencyId = Potencies.Instances.Standard.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("f1557766-5921-4ad8-a7e8-335b9e463632"), "You gain a +1 item bonus to Acrobatics checks to Escape and Squeeze")
					.Build(),
            };

            yield return new ArmorPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Slick (Greater)",
                Usage = "Etched onto armor.",
                Level = 8,
                Price = 45000,
                PotencyId = Potencies.Instances.Greater.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("d7979fb9-e44a-441c-bafe-c8b030876b3d"), "You gain a +2 item bonus to Acrobatics checks to Escape and Squeeze")
					.Build(),
            };

            yield return new ArmorPropertyRuneVariant
            {
                Id = MAJOR_ID,
                Name = "Slick (Major)",
                Usage = "Etched onto armor.",
                Level = 16,
                Price = 900000,
                PotencyId = Potencies.Instances.Major.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("f99a7612-a613-4ab5-bf9c-99ba1ca6873f"), "You gain a +3 item bonus to Acrobatics checks to Escape and Squeeze")
					.Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4761beee-027d-4fa7-979d-1c3f849b888b"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("5d0fbe13-d6bc-4ac6-b1be-f3fb115edaff"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29dc57f2-7c63-4b53-ad42-4fe7abced5c9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 583
            };
        }
    }
}
