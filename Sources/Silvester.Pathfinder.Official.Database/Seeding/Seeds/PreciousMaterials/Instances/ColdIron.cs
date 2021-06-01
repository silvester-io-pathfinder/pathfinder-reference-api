using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterials.Instances
{
    public class ColdIron : Template
    {
        public static readonly Guid ID = Guid.Parse("ac517d80-af61-4e0a-a5b0-af7a9fc85789");

        protected override PreciousMaterial GetMaterial()
        {
            return new PreciousMaterial
            {
                Id = ID,
                Name = "Cold Iron",
                ShieldId = PreciousMaterialShields.Instances.ColdIronShield.ID,
                WeaponId = PreciousMaterialWeapons.Instances.ColdIronWeapon.ID,
                ArmorId = PreciousMaterialArmors.Instances.ColdIronArmor.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2fa636c4-57a8-450e-9a25-3cce978f3c61"), Type = TextBlockType.Text, Text = "Weapons made from cold iron are deadly to demons and fey alike. Cold iron looks like normal iron but is mined from particularly pure sources and shaped with little or no heat. This process is extremely difficult, especially for high-grade cold iron items." };
        }

        protected override IEnumerable<PreciousMaterialItem> GetItems()
        {
            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("8436793a-4432-4fff-a22a-b2bd5ae08a3c"),
                Hardness = 5,
                HitPoints = 20,
                BrokenThreshold = 10,
                CategoryId = PreciousMaterialItemCategories.Instances.ThinItems.ID,
                GradeId = ItemGrades.Instances.LowGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("fe98ffaf-d428-4c1e-86d8-12ae67e3ae92"),
                Hardness = 7,
                HitPoints = 28,
                BrokenThreshold = 14,
                CategoryId = PreciousMaterialItemCategories.Instances.ThinItems.ID,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("cd2b3bad-6c5f-4409-b168-247d8febd689"),
                Hardness = 10,
                HitPoints = 40,
                BrokenThreshold = 20,
                CategoryId = PreciousMaterialItemCategories.Instances.ThinItems.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("975f3392-c268-4c31-a57a-1d8d8cb9959b"),
                Hardness = 9,
                HitPoints = 36,
                BrokenThreshold = 18,
                CategoryId = PreciousMaterialItemCategories.Instances.Items.ID,
                GradeId = ItemGrades.Instances.LowGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("ac16b926-709c-4667-aa4f-af06b500fe45"),
                Hardness = 11,
                HitPoints = 44,
                BrokenThreshold = 22,
                CategoryId = PreciousMaterialItemCategories.Instances.Items.ID,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("3ea1cd80-b505-4bf9-86ad-0b46312e7c73"),
                Hardness = 14,
                HitPoints = 56,
                BrokenThreshold = 28,
                CategoryId = PreciousMaterialItemCategories.Instances.Items.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("f03d243c-3584-4cb9-bf18-608df11981e7"),
                Hardness = 18,
                HitPoints = 72,
                BrokenThreshold = 36,
                CategoryId = PreciousMaterialItemCategories.Instances.Structures.ID,
                GradeId = ItemGrades.Instances.LowGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("ca861616-94e4-4228-b7e1-4603605fc311"),
                Hardness = 22,
                HitPoints = 88,
                BrokenThreshold = 44,
                CategoryId = PreciousMaterialItemCategories.Instances.Structures.ID,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("5c670b37-8d52-4564-a320-c6247af28045"),
                Hardness = 28,
                HitPoints = 112,
                BrokenThreshold = 56,
                CategoryId = PreciousMaterialItemCategories.Instances.Structures.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };
        }

        protected override IEnumerable<PreciousMaterialVariant> GetVariants()
        {
            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("2f5b2bf5-6e4d-400b-8f77-092e0775a3da"),
                Name = "Cold Iron Chunk",
                BulkId = Bulks.Instances.LightBulk.ID,
                ItemLevel = 0,
                Price = 1000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("8540fd11-2d77-4ef0-84b4-bec2f4c303dd"),
                Name = "Cold Iron Ingot",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 0,
                Price = 10000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("9fe9bdba-ddb4-4881-9c36-b82fba29a653"),
                Name = "Cold Iron Object",
                NameAddendum = "Low Grade",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 2,
                Price = 2000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("6f3fd4f0-6d38-4efe-8b97-84a56719a293"),
                Name = "Cold Iron Object",
                NameAddendum = "Standard Grade",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 7,
                Price = 25000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("fa7999f5-fb3c-40d2-8f6f-6cbd01068502"),
                Name = "Cold Iron Object",
                NameAddendum = "High Grade",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 15,
                Price = 450000
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Precious.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67cad0db-991b-4993-8626-32aa04f77541"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 578
            };
        }
    }
}
