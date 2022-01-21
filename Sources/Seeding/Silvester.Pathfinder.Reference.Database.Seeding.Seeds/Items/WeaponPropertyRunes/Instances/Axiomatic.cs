using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Axiomatic : Template
    {
        public static readonly Guid ID = Guid.Parse("6e45f674-8263-4aad-9d32-75f663ef8453");
        public static readonly Guid STANDARD_ID = Guid.Parse("0f9ca3f6-5f7e-43cd-ac46-07cbf12493df");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Axiomatic",
            };
        }


        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Axiomatic",
                Usage = "Etched onto a weapon without an anarchic rune.",
                CraftingRequirements = "You are lawful.",
                Level = 11,
                Price = 140000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("1527ad18-d41f-4eda-b9df-293ddfe5b247"), "Complex and symmetrical, an axiomatic rune imbues a weapon with lawful energy. A weapon with this rune deals an additional 1d6 lawful damage against chaotic targets. If you are chaotic, you are enfeebled 2 while carrying or wielding this weapon.")
                    .Text(Guid.Parse("89f4c857-4818-4bd6-a2dd-7c98a3a9bb42"), "When you critically succeed at an attack roll with this weapon against a chaotic creature, instead of rolling, count each weapon damage die as average damage rounded up (3 for d4, 4 for d6, 5 for d8, 6 for d10, 7 for d12).")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0d77cd18-3c3f-410e-b5c5-535dbf688ef3"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("0c9c0713-73bb-4876-a649-d6056d17ca1f"), Traits.Instances.Lawful.ID);
            builder.Add(Guid.Parse("d0f3627e-3bce-4075-b220-cbd6fa7608b4"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8faf47e4-fe13-4b28-9717-1fb83543e2db"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 583
            };
        }
    }
}
