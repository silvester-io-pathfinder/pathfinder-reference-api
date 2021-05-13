using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialWeapons.Instances
{
    public class AdamantineWeapon : Template
    {
        public readonly Guid ID = Guid.Parse("29b7ba2b-f6ef-46ce-9966-04ca06d282ba");

        protected override PreciousMaterialWeapon GetWeapon()
        {
            return new PreciousMaterialWeapon
            {
                Id = ID,
                Name = "Adamantine Weapon",
                MaterialId = PreciousMaterials.Instances.Adamantine.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2bfa2361-2c6b-481e-9cd1-097f7cd30880"), Type = TextBlockType.Text, Text = "Adamantine weapons have a shiny black appearance and cut through lesser items with ease. They treat any object they hit as if it had half as much Hardness as usual, unless the object’s Hardness is greater than that of the adamantine weapon." };
        }

        protected override IEnumerable<PreciousMaterialWeaponVariant> GetVariants()
        {
            yield return new PreciousMaterialWeaponVariant
            {
                Id = Guid.Parse("91eeee71-c3d8-4879-a23a-d3cd9d962177"),
                CraftRequirements = "At least 175 gp of adamantine + 17.5 gp per Bulk.",
                Price = 140000,
                AdditionalPricePerBulk = 14000,
                ItemLevel = 11,
                GradeId = ItemGrades.Instances.StandardGrade.ID
            };

            yield return new PreciousMaterialWeaponVariant
            {
                Id = Guid.Parse("84fdb447-59be-49c5-b295-be6aad91157c"),
                CraftRequirements = "At least 6,750 gp of adamantine + 675 gp per Bulk.",
                Price = 1350000,
                AdditionalPricePerBulk = 135000,
                ItemLevel = 17,
                GradeId = ItemGrades.Instances.HighGrade.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("123c6656-26b5-469f-a00e-1e6553608a14"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 599
            };
        }
    }
}
