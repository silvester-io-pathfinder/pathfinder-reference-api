using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialShields.Instances
{
    public class AdamantineShield : Template
    {
        public readonly Guid ID = Guid.Parse("f0d45f1c-537b-4276-a11a-8e164138b552");

        protected override PreciousMaterialShield GetShield()
        {
            return new PreciousMaterialShield
            {
                Id = ID,
                Name = "Adamantine",
                MaterialId = PreciousMaterials.Instances.Silver.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b52e923f-ac3d-4bfa-87d8-a79f863e2046"), Type = TextBlockType.Text, Text = "" };
        }

        protected override IEnumerable<PreciousMaterialShieldVariant> GetVariants()
        {
            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("2eac1802-85b2-4f84-a33b-eb371785a8be"),
                Name = "Buckler",
                CraftRequirements = "Adamantine worth at least 50 gp.",
                Price = 40000,
                Hardness = 8,
                HitPoints = 32,
                BrokenThreshold = 16,
                ItemLevel = 8,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("75f5b530-9d51-4cc6-a37a-b2633e004e30"),
                Name = "Shield",
                CraftRequirements = "Adamantine worth at least 55 gp.",
                Price = 44000,
                Hardness = 10,
                HitPoints = 40,
                BrokenThreshold = 20,
                ItemLevel = 8,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
                BulkId = Bulks.Instances.OneBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("b36c8b2f-fd4a-4505-927a-f5c4b3f8d1ce"),
                Name = "Buckler",
                CraftRequirements = "Adamantine worth at least 4,000 gp.",
                Price = 800000,
                Hardness = 11,
                HitPoints = 44,
                BrokenThreshold = 22,
                ItemLevel = 16,
                GradeId = ItemGrades.Instances.HighGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("0ca03eca-0c4c-47a6-952c-e44bac483f9d"),
                Name = "Shield",
                CraftRequirements = "Adamantine worth at least 4,400 gp.",
                Price = 880000,
                Hardness = 13,
                HitPoints = 52,
                BrokenThreshold = 26,
                ItemLevel = 16,
                GradeId = ItemGrades.Instances.HighGrade.ID,
                BulkId = Bulks.Instances.OneBulk.ID
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
                Id = Guid.Parse("36f21c1e-a1d8-4181-831b-3a477bb1c7e0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 586
            };
        }
    }
}
