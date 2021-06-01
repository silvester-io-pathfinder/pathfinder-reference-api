using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialWeapons.Instances
{
    public class DarkwoodWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("5b49c336-f62c-4bf8-9cd5-967e458b6f2c");

        protected override PreciousMaterialWeapon GetWeapon()
        {
            return new PreciousMaterialWeapon
            {
                Id = ID,
                Name = "Darkwood Weapon",
                MaterialId = PreciousMaterials.Instances.Darkwood.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2caacf7f-f509-44ff-be28-b7a8c10d5d87"), Type = TextBlockType.Text, Text = "Darkwood weapons are as dark as ebony, with a slight purple tint. A darkwood weapon’s Bulk is reduced by 1 (or to light Bulk if its normal Bulk is 1, with no effect on a weapon that normally has light Bulk)." };
        }

        protected override IEnumerable<PreciousMaterialWeaponVariant> GetVariants()
        {
            yield return new PreciousMaterialWeaponVariant
            {
                Id = Guid.Parse("47ec103e-d378-4b88-ad9d-e159646aa369"),
                CraftRequirements = "At least 175 gp of darkwood + 17.5 gp per Bulk.",
                Price = 140000,
                AdditionalPricePerBulk = 14000,
                ItemLevel = 11,
                GradeId = ItemGrades.Instances.StandardGrade.ID
            };

            yield return new PreciousMaterialWeaponVariant
            {
                Id = Guid.Parse("b58f65f7-cbbb-4433-8d0c-08bc36032e96"),
                CraftRequirements = "At least 6,750 gp of darkwood + 675 gp per Bulk.",
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
                Id = Guid.Parse("be3850ec-9860-48d7-acee-e49ea7f797df"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 599
            };
        }
    }
}
