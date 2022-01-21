using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterials.Instances
{
    public class Silver : Template
    {
        public static readonly Guid ID = Guid.Parse("e0b4477f-abea-49ac-9bf0-2da2291a7215");

        protected override PreciousMaterial GetMaterial()
        {
            return new PreciousMaterial
            {
                Id = ID,
                Name = "Silver",
                ShieldId = PreciousMaterialShields.Instances.SilverShield.ID,
                WeaponId = PreciousMaterialWeapons.Instances.SilverWeapon.ID,
                ArmorId = PreciousMaterialArmors.Instances.SilverArmor.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("736cd527-7274-4ed9-8c7e-767fe2c1a4e7"), Type = TextBlockType.Text, Text = "Silver weapons are a bane to creatures ranging from devils to werewolves. Silver items are less durable than steel items, and low-grade silver items are usually merely silver-plated." };
        }

        protected override IEnumerable<PreciousMaterialObjectInformation> GetObjectInformations()
        {
            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("5e24639d-9559-442b-9bc1-7ea2d85e5aaf"),
                Hardness = 3,
                HitPoints = 12,
                BrokenThreshold = 6,
                CategoryId = PreciousMaterialObjectCategories.Instances.ThinItems.ID,
                GradeId = ObjectGrades.Instances.LowGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("80084152-8810-4a72-9335-6590313e8921"),
                Hardness = 5,
                HitPoints = 20,
                BrokenThreshold = 10,
                CategoryId = PreciousMaterialObjectCategories.Instances.ThinItems.ID,
                GradeId = ObjectGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("4a94d446-0b2b-4184-a004-f0d72d2e7183"),
                Hardness = 8,
                HitPoints = 32,
                BrokenThreshold = 16,
                CategoryId = PreciousMaterialObjectCategories.Instances.ThinItems.ID,
                GradeId = ObjectGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("257c8f2c-6820-4df9-a0f7-b12929211b8e"),
                Hardness = 5,
                HitPoints = 20,
                BrokenThreshold = 10,
                CategoryId = PreciousMaterialObjectCategories.Instances.Items.ID,
                GradeId = ObjectGrades.Instances.LowGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("078e92a4-c699-4666-8e7d-bca2ef0c3656"),
                Hardness = 7,
                HitPoints = 28,
                BrokenThreshold = 14,
                CategoryId = PreciousMaterialObjectCategories.Instances.Items.ID,
                GradeId = ObjectGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("0f92acd1-9274-4c0b-926a-ef1b5e6915ef"),
                Hardness = 10,
                HitPoints = 40,
                BrokenThreshold = 20,
                CategoryId = PreciousMaterialObjectCategories.Instances.Items.ID,
                GradeId = ObjectGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("668c936b-536f-47de-93d0-8ab157b5dd93"),
                Hardness = 10,
                HitPoints = 40,
                BrokenThreshold = 20,
                CategoryId = PreciousMaterialObjectCategories.Instances.Structures.ID,
                GradeId = ObjectGrades.Instances.LowGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("98b8e396-3342-422e-bee8-ea26de4041e2"),
                Hardness = 14,
                HitPoints = 56,
                BrokenThreshold = 28,
                CategoryId = PreciousMaterialObjectCategories.Instances.Structures.ID,
                GradeId = ObjectGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("c5f081b1-c300-4da3-83f5-cb2b40024434"),
                Hardness = 20,
                HitPoints = 80,
                BrokenThreshold = 40,
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
                Id = Guid.Parse("980570d9-f844-4cac-b672-26532d63741f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 579
            };
        }
    }
}
