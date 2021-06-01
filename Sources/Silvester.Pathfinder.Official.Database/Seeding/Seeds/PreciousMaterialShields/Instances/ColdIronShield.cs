using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialShields.Instances
{
    public class ColdIronShield : Template
    {
        public static readonly Guid ID = Guid.Parse("dd42fda1-c0cb-42f5-969c-8c5db167fcfe");

        protected override PreciousMaterialShield GetShield()
        {
            return new PreciousMaterialShield
            {
                Id = ID,
                Name = "Cold Iron",
                MaterialId = PreciousMaterials.Instances.ColdIron.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("861a437f-5dda-4173-8143-0986ab0ef867"), Type = TextBlockType.Text, Text = "Cold iron shields don’t typically have an additional effect, though when used for a shield bash, they are cold iron weapons." };
        }

        protected override IEnumerable<PreciousMaterialShieldVariant> GetVariants()
        {
            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("d0f9d1bb-28f4-44e9-b5ad-5690bc974879"),
                Name = "Buckler",
                CraftRequirements = "Cold iron worth at least 15 sp.",
                Price = 3000,
                ItemLevel = 2,
                Hardness = 3,
                HitPoints = 12,
                BrokenThreshold = 6,
                GradeId = ItemGrades.Instances.LowGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("4731ed9d-9917-4878-9c30-b1d60e84f59f"),
                Name = "Shield",
                CraftRequirements = "Cold iron worth at least 17 sp.",
                Price = 3400,
                Hardness = 5,
                HitPoints = 20,
                BrokenThreshold = 10,
                ItemLevel = 2,
                GradeId = ItemGrades.Instances.LowGrade.ID,
                BulkId = Bulks.Instances.OneBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("f9ea9ab1-a08a-463d-9f18-961d4371ad4b"),
                Name = "Buckler",
                CraftRequirements = "Cold iron worth at least 375 sp.",
                Price = 30000,
                Hardness = 5,
                HitPoints = 20,
                BrokenThreshold = 10,
                ItemLevel = 7,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("5a1c2a9f-5614-4165-ad3e-d95ce704e33a"),
                Name = "Shield",
                CraftRequirements = "Cold iron worth at least 425 sp.",
                Price = 34000,
                Hardness = 7,
                HitPoints = 28,
                BrokenThreshold = 14,
                ItemLevel = 7,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
                BulkId = Bulks.Instances.OneBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("be3c54a6-f030-45c7-b715-b18d92761990"),
                Name = "Buckler",
                CraftRequirements = "Cold iron worth at least 2,500 gp.",
                Price = 500000,
                Hardness = 8,
                HitPoints = 32,
                BrokenThreshold = 16,
                ItemLevel = 15,
                GradeId = ItemGrades.Instances.HighGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("40627466-f3ab-47a3-b4e2-97348dd0f449"),
                Name = "Shield",
                CraftRequirements = "Cold iron worth at least 2,750 gp.",
                Price = 550000,
                Hardness = 10,
                HitPoints = 40,
                BrokenThreshold = 20,
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
                Id = Guid.Parse("3e7cf8a2-f703-4da3-8eea-9546fd59d20b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 586
            };
        }
    }
}
