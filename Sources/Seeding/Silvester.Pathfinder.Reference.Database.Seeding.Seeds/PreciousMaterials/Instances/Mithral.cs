using Silvester.Pathfinder.Reference.Database.Models.Entities;
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
            yield return new TextBlock { Id = Guid.Parse("f2112b91-2fe0-4160-80af-bd9cfa4f77a5"), Type = TextBlockType.Text, Text = "Mithral is renowned for its lightness, durability, and effectiveness against a range of creatures including devils and lycanthropes. It has the same sheen as silver but a slightly lighter hue. Mithral weapons and armor are treated as if they were silver for the purpose of damaging creatures with weakness to silver. A metal item made of mithral is lighter than one made of iron or steel: the item's Bulk is reduced by 1 (reduced to light Bulk if its normal Bulk is 1, with no effect on an item that normally has light Bulk). The Price of an item made of this material is based on the item's normal Bulk, not its reduced Bulk for being made of mithral, but reduce the Bulk before making any further Bulk adjustments for the size of the item." };
        }

        protected override IEnumerable<PreciousMaterialObjectInformation> GetObjectInformations()
        {
            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("103a7222-f1db-4ca5-a393-13fb5ffbf400"),
                Hardness = 5,
                HitPoints = 20,
                BrokenThreshold = 10,
                CategoryId = PreciousMaterialObjectCategories.Instances.ThinItems.ID,
                GradeId = ObjectGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("65c4c13e-cda8-422e-a70f-c0e6cd0c68be"),
                Hardness = 8,
                HitPoints = 32,
                BrokenThreshold = 16,
                CategoryId = PreciousMaterialObjectCategories.Instances.ThinItems.ID,
                GradeId = ObjectGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("5527b3e0-a18e-4490-9392-b9121e488002"),
                Hardness = 9,
                HitPoints = 36,
                BrokenThreshold = 18,
                CategoryId = PreciousMaterialObjectCategories.Instances.Items.ID,
                GradeId = ObjectGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("ed08361f-14bd-4263-b256-5dc832adb913"),
                Hardness = 12,
                HitPoints = 48,
                BrokenThreshold = 24,
                CategoryId = PreciousMaterialObjectCategories.Instances.Items.ID,
                GradeId = ObjectGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("0c676437-e33c-4f8c-a37c-fe8e0a2f3f0f"),
                Hardness = 18,
                HitPoints = 72,
                BrokenThreshold = 36,
                CategoryId = PreciousMaterialObjectCategories.Instances.Structures.ID,
                GradeId = ObjectGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("ac718a64-fa4e-4ee3-8129-5f50c5a75bfd"),
                Hardness = 24,
                HitPoints = 96,
                BrokenThreshold = 48,
                CategoryId = PreciousMaterialObjectCategories.Instances.Structures.ID,
                GradeId = ObjectGrades.Instances.HighGrade.ID,
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
