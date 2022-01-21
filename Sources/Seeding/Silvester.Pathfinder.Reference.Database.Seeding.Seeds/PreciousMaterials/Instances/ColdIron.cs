using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterials.Instances
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

        protected override IEnumerable<PreciousMaterialObjectInformation> GetObjectInformations()
        {
            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("8436793a-4432-4fff-a22a-b2bd5ae08a3c"),
                Hardness = 5,
                HitPoints = 20,
                BrokenThreshold = 10,
                CategoryId = PreciousMaterialObjectCategories.Instances.ThinItems.ID,
                GradeId = ObjectGrades.Instances.LowGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("fe98ffaf-d428-4c1e-86d8-12ae67e3ae92"),
                Hardness = 7,
                HitPoints = 28,
                BrokenThreshold = 14,
                CategoryId = PreciousMaterialObjectCategories.Instances.ThinItems.ID,
                GradeId = ObjectGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("cd2b3bad-6c5f-4409-b168-247d8febd689"),
                Hardness = 10,
                HitPoints = 40,
                BrokenThreshold = 20,
                CategoryId = PreciousMaterialObjectCategories.Instances.ThinItems.ID,
                GradeId = ObjectGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("975f3392-c268-4c31-a57a-1d8d8cb9959b"),
                Hardness = 9,
                HitPoints = 36,
                BrokenThreshold = 18,
                CategoryId = PreciousMaterialObjectCategories.Instances.Items.ID,
                GradeId = ObjectGrades.Instances.LowGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("ac16b926-709c-4667-aa4f-af06b500fe45"),
                Hardness = 11,
                HitPoints = 44,
                BrokenThreshold = 22,
                CategoryId = PreciousMaterialObjectCategories.Instances.Items.ID,
                GradeId = ObjectGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("3ea1cd80-b505-4bf9-86ad-0b46312e7c73"),
                Hardness = 14,
                HitPoints = 56,
                BrokenThreshold = 28,
                CategoryId = PreciousMaterialObjectCategories.Instances.Items.ID,
                GradeId = ObjectGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("f03d243c-3584-4cb9-bf18-608df11981e7"),
                Hardness = 18,
                HitPoints = 72,
                BrokenThreshold = 36,
                CategoryId = PreciousMaterialObjectCategories.Instances.Structures.ID,
                GradeId = ObjectGrades.Instances.LowGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("ca861616-94e4-4228-b7e1-4603605fc311"),
                Hardness = 22,
                HitPoints = 88,
                BrokenThreshold = 44,
                CategoryId = PreciousMaterialObjectCategories.Instances.Structures.ID,
                GradeId = ObjectGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("5c670b37-8d52-4564-a320-c6247af28045"),
                Hardness = 28,
                HitPoints = 112,
                BrokenThreshold = 56,
                CategoryId = PreciousMaterialObjectCategories.Instances.Structures.ID,
                GradeId = ObjectGrades.Instances.HighGrade.ID,
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
