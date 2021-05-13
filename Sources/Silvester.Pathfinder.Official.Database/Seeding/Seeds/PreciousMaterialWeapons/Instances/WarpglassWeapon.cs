using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialWeapons.Instances
{
    public class WarpglassWeapon : Template
    {
        public readonly Guid ID = Guid.Parse("7bfe9197-17dd-4499-931d-7dd4816a12dd");

        protected override PreciousMaterialWeapon GetWeapon()
        {
            return new PreciousMaterialWeapon
            {
                Id = ID,
                Name = "Warpglass Weapon",
                MaterialId = PreciousMaterials.Instances.Silver.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3452368c-3873-475d-b0a3-58953448b478"), Type = TextBlockType.Text, Text = "If you critically hit a creature with a Strike with a warpglass weapon, the target is affected by a warpwave and automatically fails its saving throw." };
        }

        protected override IEnumerable<PreciousMaterialWeaponVariant> GetVariants()
        {
            yield return new PreciousMaterialWeaponVariant
            {
                Id = Guid.Parse("471986fa-9494-4389-a613-b912762f7fd9"),
                CraftRequirements = "At least 7,000 gp of warpglass + 700 gp per Bulk.",
                Price = 1400000,
                AdditionalPricePerBulk = 140000,
                ItemLevel = 17,
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
                Id = Guid.Parse("1e1d574e-635e-4497-ad1e-847880b208f1"),
                SourceId = Sources.Instances.Pathfinder162.ID,
                Page = 75
            };
        }
    }
}
