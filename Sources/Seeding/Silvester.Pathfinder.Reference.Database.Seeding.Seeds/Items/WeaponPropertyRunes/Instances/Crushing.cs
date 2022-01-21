using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Crushing : Template
    {
        public static readonly Guid ID = Guid.Parse("55a1745a-785f-4f77-9730-6c0b1c002533");

        public static readonly Guid STANDARD_ID = Guid.Parse("c7d2d852-8387-4fa9-acff-28ed9e457f12");
        public static readonly Guid GREATER_ID = Guid.Parse("98b4d4e3-85a5-4ab9-aace-d18808ea564e");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Crushing",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Crushing",
                Usage = "Etched onto a bludgeoning weapon.",
                Level = 3,
                Price = 5000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new WeaponPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Crushing (Greater)",
                Usage = "Etched onto a bludgeoning weapon.",
                Level = 9,
                Price = 65000,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("bfd3176e-af58-4e8c-9e5e-fdd575c74660"), "Your critical hits leave the target clumsy 2 and enfeebled 2 until the end of your next turn.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a3f8eb6f-2b05-4ba9-acb9-29d55755fe01"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("ea1e0cce-221e-43f1-8ff5-d93698ee8d25"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("e84bd4f3-28e2-4736-acea-d2092c0575d5"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14250085-5d14-46c8-9989-9fdfeeefeeff"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 42
            };
        }
    }
}
