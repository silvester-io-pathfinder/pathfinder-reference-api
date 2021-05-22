using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialWeapons.Instances
{
    public class SilverWeapon : Template
    {
        public readonly Guid ID = Guid.Parse("37c439ab-d41a-4777-8fe2-d0efe5bcc22b");

        protected override PreciousMaterialWeapon GetWeapon()
        {
            return new PreciousMaterialWeapon
            {
                Id = ID,
                Name = "Silver Weapon",
                MaterialId = PreciousMaterials.Instances.Silver.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d4a9f3fe-2981-4de5-b1fd-3a8b9f99130a"), Type = TextBlockType.Text, Text = "Silver weapons deal additional damage to creatures with weakness to silver, like werewolves, and ignore the resistances of some other creatures, like devils." };
        }

        protected override IEnumerable<PreciousMaterialWeaponVariant> GetVariants()
        {
            yield return new PreciousMaterialWeaponVariant
            {
                Id = Guid.Parse("26a12d43-3d55-4020-a754-61aafe80646b"),
                CraftRequirements = "At least 20 sp of silver + 2 sp per Bulk.",
                Price = 4000,
                AdditionalPricePerBulk = 400,
                ItemLevel = 2,
                GradeId = ItemGrades.Instances.LowGrade.ID
            };

            yield return new PreciousMaterialWeaponVariant
            {
                Id = Guid.Parse("b105eb6c-39d8-486e-8c2a-48f7f2048f40"),
                CraftRequirements = "At least 110 gp of silver + 11 gp per Bulk.",
                Price = 88000,
                AdditionalPricePerBulk = 8800,
                ItemLevel = 10,
                GradeId = ItemGrades.Instances.StandardGrade.ID
            };

            yield return new PreciousMaterialWeaponVariant
            {
                Id = Guid.Parse("37bdb433-1283-40e8-a2ff-12598db42f49"),
                CraftRequirements = "At least 4,500 gp of silver + 450 gp per Bulk.",
                Price = 900000,
                AdditionalPricePerBulk = 90000,
                ItemLevel = 16,
                GradeId = ItemGrades.Instances.HighGrade.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3143014e-e836-4c36-a856-e89ef93f9213"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 599
            };
        }
    }
}
