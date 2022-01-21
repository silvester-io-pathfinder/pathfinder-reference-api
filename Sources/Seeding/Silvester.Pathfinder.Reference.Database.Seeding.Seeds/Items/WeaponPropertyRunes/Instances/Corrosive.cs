using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Corrosive : Template
    {
        public static readonly Guid ID = Guid.Parse("83bb5d56-43f3-42c8-bd77-d8f5e7209d22");
        public static readonly Guid STANDARD_ID = Guid.Parse("70aebf9d-a280-4f70-9822-ea951a9c0023");
        public static readonly Guid GREATER_ID = Guid.Parse("7e9d4453-15b3-4ce9-b9b7-305949c66255");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Corrosive",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Corrosive",
                Usage = "Etched onto a weapon.",
                Level = 8,
                Price = 50000,
                RarityId = Rarities.Instances.Common.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("1cb19254-c8f0-4214-8e82-4070dd4a805c"), "Acid sizzles across the surface of the weapon. When you hit with the weapon, add 1d6 acid damage to the damage dealt. In addition, on a critical hit, the target's armor (if any) takes 3d6 acid damage (before applying Hardness); if the target has a shield raised, the shield takes this damage instead.")
                    .Build()
            };

            yield return new WeaponPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Corrosive (Greater)",
                Usage = "Etched onto a weapon.",
                Level = 15,
                Price = 650000,
                RarityId = Rarities.Instances.Common.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("df27e8fb-9b52-4d80-8f87-fff9fbbbdda1"), "The acid damage dealt by this weapon ignores the target's acid resistance. Increase the acid damage dealt to armor or a shield on a critical hit to 6d6.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c2c0fb43-546f-4786-803b-29b8ebf41c9b"), Traits.Instances.Acid.ID);
            builder.Add(Guid.Parse("bd05bd0e-8cf7-4d0b-9683-ea40002d96c5"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("0fd2b727-c5eb-4372-af0c-c694f0e7840e"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f05c6e85-4bec-4f0b-ade0-8f0e7e85e5f9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 583
            };
        }
    }
}
