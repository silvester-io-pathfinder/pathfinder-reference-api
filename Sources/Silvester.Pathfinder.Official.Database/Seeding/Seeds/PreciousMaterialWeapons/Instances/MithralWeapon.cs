using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialWeapons.Instances
{
    public class MithralWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("f4155d3a-7603-4d5b-8b61-61f60afe13bf");

        protected override PreciousMaterialWeapon GetWeapon()
        {
            return new PreciousMaterialWeapon
            {
                Id = ID,
                Name = "Mithral Weapon",
                MaterialId = PreciousMaterials.Instances.Mithral.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("29effed3-cdb7-480f-aff8-43d764b92fe3"), Type = TextBlockType.Text, Text = "Mithral weapons are slightly lighter than silver. A mithral weapon is 1 Bulk lighter than normal (or light Bulk if its normal Bulk is 1, with no effect on a weapon that normally has light Bulk)." };
        }

        protected override IEnumerable<PreciousMaterialWeaponVariant> GetVariants()
        {
            yield return new PreciousMaterialWeaponVariant
            {
                Id = Guid.Parse("5fa15879-a7a5-4a25-8a14-7b1b89148131"),
                CraftRequirements = "At least 175 gp of mithral + 17.5 gp per Bulk.",
                Price = 140000,
                AdditionalPricePerBulk = 14000,
                ItemLevel = 11,
                GradeId = ItemGrades.Instances.StandardGrade.ID
            };

            yield return new PreciousMaterialWeaponVariant
            {
                Id = Guid.Parse("a21d6bbf-8729-4636-9e66-26ce10c9abec"),
                CraftRequirements = "At least 6,750 gp of mithral + 675 gp per Bulk.",
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
                Id = Guid.Parse("dc7d6228-ec1a-4a09-95ed-2b4ec127aa98"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 599
            };
        }
    }
}
