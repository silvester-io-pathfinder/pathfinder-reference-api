using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialWeapons.Instances
{
    public class SovereignSteelWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("e5a64133-97dc-4338-bc22-4de897cc3024");

        protected override PreciousMaterialWeapon GetWeapon()
        {
            return new PreciousMaterialWeapon
            {
                Id = ID,
                Name = "Sovereign Steel Weapon",
                MaterialId = PreciousMaterials.Instances.SovereignSteel.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ce831f70-5ed3-476c-87c7-ff10f44742db"), Type = TextBlockType.Text, Text = "Sovereign steel weapons are treated as cold iron against creatures with a weakness to cold iron, like demons and fey. In addition, the noqual in sovereign steel weapons disrupts spellcasters' concentration, causing them to become stupefied 1 for 1 round on a critical hit." };
        }

        protected override IEnumerable<PreciousMaterialWeaponVariant> GetVariants()
        {
            yield return new PreciousMaterialWeaponVariant
            {
                Id = Guid.Parse("dc249dda-c1e8-43b1-9208-cf9fde3b2650"),
                CraftRequirements = "At least 100 gp of cold iron + 10 gp per Bulk plus at least 100 gp of noqual + 10 gp per Bulk.",
                Price = 160000,
                AdditionalPricePerBulk = 16000,
                ItemLevel = 12,
                GradeId = ItemGrades.Instances.StandardGrade.ID
            };

            yield return new PreciousMaterialWeaponVariant
            {
                Id = Guid.Parse("aae7431c-8dcc-42b5-9045-b92705e6b450"),
                CraftRequirements = "At least 8,000 gp of cold iron + 800 gp per Bulk plus at least 8,000 gp of noqual + 800 gp per Bulk.",
                Price = 3200000,
                AdditionalPricePerBulk = 320000,
                ItemLevel = 19,
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
                Id = Guid.Parse("6a9f462d-ae97-4cec-ae95-706e9e93e082"),
                SourceId = Sources.Instances.Legends.ID,
                Page = 77
            };
        }
    }
}
