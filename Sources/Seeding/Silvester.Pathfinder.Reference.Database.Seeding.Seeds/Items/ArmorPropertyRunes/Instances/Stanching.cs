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
    public class Stanching : Template
    {
        public static readonly Guid ID = Guid.Parse("cbf6f230-a224-4ca8-acf3-cc6dbcbc4d9f");

        public static readonly Guid STANDARD_ID = Guid.Parse("131cfb01-4089-4a49-881d-888ce971107d");
        public static readonly Guid GREATER_ID = Guid.Parse("1e3506e3-c914-4285-842f-ed392aa7901c");
        public static readonly Guid MAJOR_ID = Guid.Parse("a278e82c-d4a5-41fc-a95a-c485c8b70e6c");
        public static readonly Guid TRUE_ID = Guid.Parse("b2250020-b3ba-4a95-824c-e63233b4d01d");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Stanching",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("8324ce8f-9743-4738-8b70-0c74f32a6b14"), "These symbols close bloody wounds. ");
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Stanching",
                Usage = "Etched onto armor.",
                Level = 5,
                Price = 13000,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("f8a9d208-d3a8-4b2a-a495-0ab85b7c2fb3"), "Armor with this rune reduces the DC of the flat check to end persistent bleed damage from 15 to 12 (7 with particularly effective assistance).")
                    .Build(),
            };

            yield return new ArmorPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Stanching (Greater)",
                Usage = "Etched onto armor.",
                Level = 9,
                Price = 60000,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("0f1599d5-e70d-46ca-bb81-24082c06640f"), "Armor with this rune reduces the DC of the flat check to end persistent bleed damage from 15 to 10 (5 with particularly effective assistance).")
                    .Build(),
            };


            yield return new ArmorPropertyRuneVariant
            {
                Id = MAJOR_ID,
                Name = "Stanching (Major)",
                Usage = "Etched onto armor.",
                Level = 13,
                Price = 250000,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("64776a4c-0f35-406a-ba03-78501442eeb5"), "Armor with this rune reduces the DC of the flat check to end persistent bleed damage from 15 to 8 (3 with particularly effective assistance).")
                    .Build(),
            };


            yield return new ArmorPropertyRuneVariant
            {
                Id = TRUE_ID,
                Name = "Stanching (True)",
                Usage = "Etched onto armor.",
                Level = 17,
                Price = 1250000,
                PotencyId = Potencies.Instances.True.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("ae070e2c-cb0a-4514-ad3e-9da84c067825"), "Armor with this rune reduces the DC of the flat check to end persistent bleed damage from 15 to 5 (particularly effective assistance automatically removes the persistent bleed damage).")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("801f8ba1-fa0a-4bad-837b-f396a374b830"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("754f2180-4306-4553-b871-bcd54873a7c6"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a7615c0-a789-4042-a926-43f569c59883"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 38
            };
        }
    }
}
