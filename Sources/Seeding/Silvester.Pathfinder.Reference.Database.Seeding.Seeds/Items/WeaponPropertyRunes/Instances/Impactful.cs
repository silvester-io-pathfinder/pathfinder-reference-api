using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Impactful : Template
    {
        public static readonly Guid ID = Guid.Parse("32f8b4c1-507a-451f-8111-26a5c9a2112f");

        public static readonly Guid STANDARD_ID = Guid.Parse("67c55779-05ad-49f4-9de4-bd1ba850215a");
        public static readonly Guid GREATER_ID = Guid.Parse("68e3f33a-73ee-4f08-97f9-30d05e907025");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Impactful",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c175a466-2df2-4535-a171-91e487f9513b"), "This rune thrums with pure magical energy. Weapons with the rune deal an additional 1d6 force damage on a successful Strike.");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Impactful",
                Usage = "Etched onto a weapon.",
                Level = 10,
                Price = 100000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("e71346a0-b2bc-46ef-8aad-2665b8f1fc13"), "On a critical hit, you can choose to force the target to succeed at a DC 27 Fortitude save or be pushed 5 feet away from you.")
                    .Build()
            };

            yield return new WeaponPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Impactful (Greater)",
                Usage = "Etched onto a weapon.",
                Level = 17,
                Price = 1500000,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("72ccdfd3-3561-41e5-be34-214c9f7aedd9"), "On a critical hit, you can choose to force the target to succeed at a DC 37 Fortitude save or be pushed 10 feet away from you.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("fdc15480-539f-464b-8d01-1c9210b00c0c"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("9f506f8c-ad7d-4193-8890-3e9a88e941a4"), Traits.Instances.Force.ID);
            builder.Add(Guid.Parse("dbc31a98-210c-4f95-a791-a4646419c24e"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6366d3ef-5659-4d30-b760-ef028311d55c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 185
            };
        }
    }
}
