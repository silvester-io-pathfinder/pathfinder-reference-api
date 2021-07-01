using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialShields.Instances
{
    public class OrichalcumShield : Template
    {
        public static readonly Guid ID = Guid.Parse("7ef2acfb-7820-4a22-be1a-c97991e63e16");

        protected override PreciousMaterialShield GetShield()
        {
            return new PreciousMaterialShield
            {
                Id = ID,
                Name = "Orichalcum",
                MaterialId = PreciousMaterials.Instances.Orichalcum.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a2250e00-31de-49f9-8b72-36fcac2b1148"), Type = TextBlockType.Text, Text = "Orichalcum shields’ time-bending properties are particularly useful for keeping them intact. The first time each day an orichalcum shield would be destroyed, it is instead left with 1 Hit Point and the broken condition." };
        }

        protected override IEnumerable<PreciousMaterialShieldVariant> GetVariants()
        {
            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("58f844e5-dd63-4e7a-8ef1-2db6798063df"),
                Name = "Buckler",
                CraftRequirements = "Orichalcum worth at least 6,000 gp.",
                Price = 1200000,
                Hardness = 14,
                HitPoints = 56,
                BrokenThreshold = 28,
                ItemLevel = 17,
                GradeId = ItemGrades.Instances.HighGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("746abb2e-2de4-4e71-8e29-9f0e7720a1f5"),
                Name = "Shield",
                CraftRequirements = "Orichalcum worth at least 6,600 gp.",
                Price = 1320000,
                Hardness = 16,
                HitPoints = 64,
                BrokenThreshold = 32,
                ItemLevel = 17,
                GradeId = ItemGrades.Instances.HighGrade.ID,
                BulkId = Bulks.Instances.OneBulk.ID
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
                Id = Guid.Parse("2253c996-e021-4a04-a7a7-fc3d4f798fbd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 587
            };
        }
    }
}
