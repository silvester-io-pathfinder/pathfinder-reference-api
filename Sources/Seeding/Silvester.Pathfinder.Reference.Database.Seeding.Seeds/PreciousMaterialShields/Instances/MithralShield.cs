using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialShields.Instances
{
    public class MithralShield : Template
    {
        public static readonly Guid ID = Guid.Parse("575c98ad-c43d-4424-93a8-f0188f6de11d");

        protected override PreciousMaterialShield GetShield()
        {
            return new PreciousMaterialShield
            {
                Id = ID,
                Name = "Mithral",
                MaterialId = PreciousMaterials.Instances.Mithral.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("bf2db0e2-09ed-4a47-942e-45675b9d42e2"), Type = TextBlockType.Text, Text = "Mithral shields are 1 Bulk lighter than normal (or light Bulk if their normal Bulk is 1, with no effect on a shield that normally has light Bulk). When used for a shield bash, they are treated as silver weapons." };
        }

        protected override IEnumerable<PreciousMaterialShieldVariant> GetVariants()
        {
            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("f0e5ad9d-ed3f-4209-80cc-e45616f5786a"),
                Name = "Buckler",
                CraftRequirements = "Mithral worth at least 50 gp.",
                Price = 40000,
                Hardness = 3,
                HitPoints = 12,
                BrokenThreshold = 6,
                ItemLevel = 8,
                GradeId = ObjectGrades.Instances.StandardGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("2f781f07-94e6-4570-9807-187a5172eb04"),
                Name = "Shield",
                CraftRequirements = "Mithral worth at least 55 gp.",
                Price = 44000,
                Hardness = 5,
                HitPoints = 20,
                BrokenThreshold = 10,
                ItemLevel = 8,
                GradeId = ObjectGrades.Instances.StandardGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("79cee0e5-fc99-4bb9-86e4-065c5d481d07"),
                Name = "Buckler",
                CraftRequirements = "Mithral worth at least 4,000 gp.",
                Price = 800000,
                Hardness = 6,
                HitPoints = 24,
                BrokenThreshold = 12,
                ItemLevel = 16,
                GradeId = ObjectGrades.Instances.HighGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("ca4285c6-0ea8-497d-9415-da4fd6658166"),
                Name = "Shield",
                CraftRequirements = "At least 4,400 gp of mithral.",
                Price = 880000,
                Hardness = 8,
                HitPoints = 32,
                BrokenThreshold = 16,
                ItemLevel = 16,
                GradeId = ObjectGrades.Instances.HighGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
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
                Id = Guid.Parse("fdc93057-203a-4dc9-a836-c3d9832dce6f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 587
            };
        }
    }
}
