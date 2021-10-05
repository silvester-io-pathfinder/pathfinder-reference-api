using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterials.Instances
{
    public class Adamantine : Template
    {
        public static readonly Guid ID = Guid.Parse("2696e0dc-47a6-487c-9433-7d5dff4b4c0d");

        protected override PreciousMaterial GetMaterial()
        {
            return new PreciousMaterial
            {
                Id = ID,
                Name = "Adamantine",
                ShieldId = PreciousMaterialShields.Instances.AdamantineShield.ID,
                WeaponId = PreciousMaterialWeapons.Instances.AdamantineWeapon.ID,
                ArmorId = PreciousMaterialArmors.Instances.AdamantineArmor.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5829ae74-0fca-4b15-937c-a6ef2dc17a5c"), Type = TextBlockType.Text, Text = "Mined from rocks that fell from the heavens, adamantine is one of the hardest metals known. It has a shiny, black appearance, and it is prized for its amazing resiliency and ability to hold an incredibly sharp edge." };
        }

        protected override IEnumerable<PreciousMaterialItem> GetItems()
        {
            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("9a730144-b4e2-4b07-94d6-26a2d6920698"),
                Hardness = 10,
                HitPoints = 40,
                BrokenThreshold = 20,
                CategoryId = PreciousMaterialItemCategories.Instances.ThinItems.ID,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("cfea7a2d-672b-47fd-b63d-0d194a58ed2d"),
                Hardness = 13,
                HitPoints = 52,
                BrokenThreshold = 26,
                CategoryId = PreciousMaterialItemCategories.Instances.ThinItems.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("5ee54336-e4a5-4588-983d-faad48b02586"),
                Hardness = 14,
                HitPoints = 56,
                BrokenThreshold = 28,
                CategoryId = PreciousMaterialItemCategories.Instances.Items.ID,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("a625902c-a091-42e3-b827-c9a26c94332e"),
                Hardness = 17,
                HitPoints = 68,
                BrokenThreshold = 34,
                CategoryId = PreciousMaterialItemCategories.Instances.Items.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("9634872e-6b8a-4663-b679-d7eec6f7d140"),
                Hardness = 28,
                HitPoints = 112,
                BrokenThreshold = 56,
                CategoryId = PreciousMaterialItemCategories.Instances.Structures.ID,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("a3614a92-71cb-42f9-8152-ad4d62df3684"),
                Hardness = 34,
                HitPoints = 136,
                BrokenThreshold = 68,
                CategoryId = PreciousMaterialItemCategories.Instances.Structures.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };
        }

        protected override IEnumerable<PreciousMaterialVariant> GetVariants()
        {
            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("d0ffa114-5af2-4660-8ac6-b3702242993c"),
                Name = "Adamantine Chunk",
                BulkId = Bulks.Instances.LightBulk.ID,
                ItemLevel = 0,
                Price = 50000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("1d32e18c-edf0-4e27-b0e4-c788b28c70c4"),
                Name = "Adamantine Ingot",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 0,
                Price = 500000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("2d238ecb-edb4-40e3-b109-fb649d767c89"),
                Name = "Adamantine Object",
                NameAddendum = "Standard Grade",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 8,
                Price = 35000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("4f99400d-c32f-4806-85ba-2f8282f30c27"),
                Name = "Adamantine Object",
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
                Id = Guid.Parse("07295f4a-ccb0-499c-adda-4b71482502e0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 578
            };
        }
    }
}
