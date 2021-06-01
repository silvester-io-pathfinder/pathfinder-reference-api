using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialShields.Instances
{
    public class SilverShield : Template
    {
        public static readonly Guid ID = Guid.Parse("0c4d2501-e887-4cde-9714-e25c9c96a5fe");

        protected override PreciousMaterialShield GetShield()
        {
            return new PreciousMaterialShield
            {
                Id = ID,
                Name = "Silver",
                MaterialId = PreciousMaterials.Instances.Silver.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0e6b4e48-e741-45da-85e4-823a172ea0c4"), Type = TextBlockType.Text, Text = "Silver shields don’t typically have an additional effect, though when used for a shield bash, they are silver weapons." };
        }

        protected override IEnumerable<PreciousMaterialShieldVariant> GetVariants()
        {
            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("f72cdc4a-f4d0-4c72-a404-27cd5b89d9dc"),
                Name = "Buckler",
                CraftRequirements = "Silver worth at least 15 sp.",
                Price = 3000,
                ItemLevel = 2,
                Hardness = 1,
                HitPoints = 4,
                BrokenThreshold = 2,
                GradeId = ItemGrades.Instances.LowGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("201e65ea-cd25-482e-8ea1-cf28d863207b"),
                Name = "Shield",
                CraftRequirements = "Silver worth at least 17 sp.",
                Price = 3400,
                Hardness = 3,
                HitPoints = 12,
                BrokenThreshold = 6,
                ItemLevel = 2,
                GradeId = ItemGrades.Instances.LowGrade.ID,
                BulkId = Bulks.Instances.OneBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("f0c20290-6840-416e-b616-39aaf8c44187"),
                Name = "Buckler",
                CraftRequirements = "Silver worth at least 375 sp.",
                Price = 30000,
                Hardness = 3,
                HitPoints = 12,
                BrokenThreshold = 6,
                ItemLevel = 7,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("fa0d5199-2dc2-4201-82d9-c4234ae42eb1"),
                Name = "Shield",
                CraftRequirements = "Silver worth at least 3425 sp.",
                Price = 34000,
                Hardness = 5,
                HitPoints = 20,
                BrokenThreshold = 10,
                ItemLevel = 7,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
                BulkId = Bulks.Instances.OneBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("580d5115-b9d8-4afe-862f-be6f3766cec7"),
                Name = "Buckler",
                CraftRequirements = "Silver worth at least 2,500 gp.",
                Price = 500000,
                Hardness = 6,
                HitPoints = 24,
                BrokenThreshold = 12,
                ItemLevel = 15,
                GradeId = ItemGrades.Instances.HighGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("77d654fd-90b4-4a5e-9f01-737af7625485"),
                Name = "Shield",
                CraftRequirements = "Silver worth at least 2,750 gp.",
                Price = 5500,
                Hardness = 8,
                HitPoints = 32,
                BrokenThreshold = 16,
                ItemLevel = 15,
                GradeId = ItemGrades.Instances.HighGrade.ID,
                BulkId = Bulks.Instances.OneBulk.ID
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
                Id = Guid.Parse("f940b550-061f-40d9-8d7b-eb18aa5f56b3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 587
            };
        }
    }
}
