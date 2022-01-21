using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterials.Instances
{
    public class Orichalcum : Template
    {
        public static readonly Guid ID = Guid.Parse("949a7996-a817-48bf-b947-3646e248a25a");

        protected override PreciousMaterial GetMaterial()
        {
            return new PreciousMaterial
            {
                Id = ID,
                Name = "Orichalcum",
                ShieldId = PreciousMaterialShields.Instances.OrichalcumShield.ID,
                WeaponId = PreciousMaterialWeapons.Instances.OrichalcumWeapon.ID,
                ArmorId = PreciousMaterialArmors.Instances.OrichalcumArmor.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("335d178d-d113-456c-a618-f8dd8c50fe7f"), Type = TextBlockType.Text, Text = "The most rare and valuable skymetal, orichalcum is coveted for its incredible time-related magical properties. This dull, coppery metal isn't as physically sturdy as adamantine, but orichalcum's time-bending properties protect it, granting it greater Hardness and Hit Points. If an orichalcum item takes damage but isn't destroyed, it repairs itself completely 24 hours later." };
        }

        protected override IEnumerable<PreciousMaterialObjectInformation> GetObjectInformations()
        {
            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("1aa57de0-59fb-4126-ace0-f4dc969c1da7"),
                Hardness = 16,
                HitPoints = 64,
                BrokenThreshold = 32,
                CategoryId = PreciousMaterialObjectCategories.Instances.ThinItems.ID,
                GradeId = ObjectGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("cf4aeb8d-0188-409b-83cc-6555205461d7"),
                Hardness = 18,
                HitPoints = 72,
                BrokenThreshold = 36,
                CategoryId = PreciousMaterialObjectCategories.Instances.Items.ID,
                GradeId = ObjectGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialObjectInformation
            {
                Id = Guid.Parse("f93d7557-ce24-4342-bc5d-cfcd2924f585"),
                Hardness = 35,
                HitPoints = 140,
                BrokenThreshold = 70,
                CategoryId = PreciousMaterialObjectCategories.Instances.Structures.ID,
                GradeId = ObjectGrades.Instances.HighGrade.ID,
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Precious.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca4df887-a752-4ced-a3b8-979e8c224943"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 579
            };
        }
    }
}
