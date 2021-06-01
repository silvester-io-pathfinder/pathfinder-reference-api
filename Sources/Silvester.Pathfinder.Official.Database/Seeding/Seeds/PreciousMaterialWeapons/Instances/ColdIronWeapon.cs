using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialWeapons.Instances
{
    public class ColdIronWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("b1e2cd72-1948-40c6-ba4a-96060224d4a3");

        protected override PreciousMaterialWeapon GetWeapon()
        {
            return new PreciousMaterialWeapon
            {
                Id = ID,
                Name = "Cold Iron Weapon",
                MaterialId = PreciousMaterials.Instances.ColdIron.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1ce24771-3637-4721-8913-b39f92cb1e27"), Type = TextBlockType.Text, Text = "Cold iron weapons deal additional damage to creatures with weakness to cold iron, like demons and fey." };
        }

        protected override IEnumerable<PreciousMaterialWeaponVariant> GetVariants()
        {
            yield return new PreciousMaterialWeaponVariant
            {
                Id = Guid.Parse("86e3879c-a37c-4890-9fd8-340827eacfae"),
                CraftRequirements = "At least 20 sp of cold iron + 2 sp per Bulk.",
                Price = 4000,
                AdditionalPricePerBulk = 400,
                ItemLevel = 2,
                GradeId = ItemGrades.Instances.LowGrade.ID
            };

            yield return new PreciousMaterialWeaponVariant
            {
                Id = Guid.Parse("9da14b27-6a67-4b0a-8cc5-81e620a8690c"),
                CraftRequirements = "At least 110 gp of cold iron + 11 gp per Bulk.",
                Price = 88000,
                AdditionalPricePerBulk = 8800,
                ItemLevel = 10,
                GradeId = ItemGrades.Instances.StandardGrade.ID
            };

            yield return new PreciousMaterialWeaponVariant
            {
                Id = Guid.Parse("26b5785b-9af0-4a3d-b58f-49d6a80d53f1"),
                CraftRequirements = "At least 4,500 gp of cold iron + 450 gp per Bulk.",
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
                Id = Guid.Parse("87977622-b958-4f66-9193-3ffa5d1d16fd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 599
            };
        }
    }
}
