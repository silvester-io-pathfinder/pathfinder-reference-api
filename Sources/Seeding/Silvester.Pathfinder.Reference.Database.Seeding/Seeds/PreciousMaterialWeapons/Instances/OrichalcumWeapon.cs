using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialWeapons.Instances
{
    public class OrichalcumWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("e3a80aa5-5187-40bc-8151-130f89fe9775");

        protected override PreciousMaterialWeapon GetWeapon()
        {
            return new PreciousMaterialWeapon
            {
                Id = ID,
                Name = "Orichalcum Weapon",
                MaterialId = PreciousMaterials.Instances.Silver.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e402cfb3-cb73-48ca-8086-f5ca51035314"), Type = TextBlockType.Text, Text = "Orichalcum weapons can have four magic property runes instead of three. Due to orichalcum's temporal properties, etching the speed weapon property rune onto an orichalcum weapon costs half the normal Price (though transferring the rune to a weapon made of another material requires you to first pay the remaining Price and then pay the cost to transfer)." };
        }

        protected override IEnumerable<PreciousMaterialWeaponVariant> GetVariants()
        {
            yield return new PreciousMaterialWeaponVariant
            {
                Id = Guid.Parse("418acf83-a6b5-406a-876b-01c5c43ce8c0"),
                CraftRequirements = "At least 11,250 gp of orichalcum + 1,125 gp per Bulk.",
                Price = 2250000,
                AdditionalPricePerBulk = 225000,
                ItemLevel = 18,
                GradeId = ItemGrades.Instances.HighGrade.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a92f7153-e526-41ee-b880-e74f492a2e03"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 599
            };
        }
    }
}
