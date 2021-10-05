using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterials.Instances
{
    public class Mithral : Template
    {
        public static readonly Guid ID = Guid.Parse("ec5767b8-cf91-447c-be08-9edc359c310a");

        protected override PreciousMaterial GetMaterial()
        {
            return new PreciousMaterial
            {
                Id = ID,
                Name = "Mithral",
                ShieldId = PreciousMaterialShields.Instances.MithralShield.ID,
                WeaponId = PreciousMaterialWeapons.Instances.MithralWeapon.ID,
                ArmorId = PreciousMaterialArmors.Instances.MithralArmor.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f2112b91-2fe0-4160-80af-bd9cfa4f77a5"), Type = TextBlockType.Text, Text = "Mithral is renowned for its lightness, durability, and effectiveness against a range of creatures including devils and lycanthropes. It has the same sheen as silver but a slightly lighter hue. Mithral weapons and armor are treated as if they were silver for the purpose of damaging creatures with weakness to silver. A metal item made of mithral is lighter than one made of iron or steel: the item’s Bulk is reduced by 1 (reduced to light Bulk if its normal Bulk is 1, with no effect on an item that normally has light Bulk). The Price of an item made of this material is based on the item’s normal Bulk, not its reduced Bulk for being made of mithral, but reduce the Bulk before making any further Bulk adjustments for the size of the item." };
        }

        protected override IEnumerable<PreciousMaterialItem> GetItems()
        {
            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("103a7222-f1db-4ca5-a393-13fb5ffbf400"),
                Hardness = 5,
                HitPoints = 20,
                BrokenThreshold = 10,
                CategoryId = PreciousMaterialItemCategories.Instances.ThinItems.ID,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("65c4c13e-cda8-422e-a70f-c0e6cd0c68be"),
                Hardness = 8,
                HitPoints = 32,
                BrokenThreshold = 16,
                CategoryId = PreciousMaterialItemCategories.Instances.ThinItems.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("5527b3e0-a18e-4490-9392-b9121e488002"),
                Hardness = 9,
                HitPoints = 36,
                BrokenThreshold = 18,
                CategoryId = PreciousMaterialItemCategories.Instances.Items.ID,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("ed08361f-14bd-4263-b256-5dc832adb913"),
                Hardness = 12,
                HitPoints = 48,
                BrokenThreshold = 24,
                CategoryId = PreciousMaterialItemCategories.Instances.Items.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("0c676437-e33c-4f8c-a37c-fe8e0a2f3f0f"),
                Hardness = 18,
                HitPoints = 72,
                BrokenThreshold = 36,
                CategoryId = PreciousMaterialItemCategories.Instances.Structures.ID,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("ac718a64-fa4e-4ee3-8129-5f50c5a75bfd"),
                Hardness = 24,
                HitPoints = 96,
                BrokenThreshold = 48,
                CategoryId = PreciousMaterialItemCategories.Instances.Structures.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };
        }

        protected override IEnumerable<PreciousMaterialVariant> GetVariants()
        {
            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("4fee8850-4578-4b9a-be3d-0f8e12921850"),
                Name = "Mithral Chunk",
                BulkId = Bulks.Instances.LightBulk.ID,
                ItemLevel = 0,
                Price = 50000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("9e69ae02-bf52-4fab-98a7-8b8f893cd952"),
                Name = "Mithral Ingot",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 0,
                Price = 500000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("f885fd24-e9e4-4407-a591-453d41141b49"),
                Name = "Mithral Object",
                NameAddendum = "Standard Grade",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 8,
                Price = 35000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("e6d5ad1a-364a-4816-94f1-05e651963fce"),
                Name = "Mithral Object",
                NameAddendum = "High Grade",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 16,
                Price = 600000
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Precious.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6378f71-150f-453b-baf7-f16e080995df"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 579
            };
        }
    }
}
