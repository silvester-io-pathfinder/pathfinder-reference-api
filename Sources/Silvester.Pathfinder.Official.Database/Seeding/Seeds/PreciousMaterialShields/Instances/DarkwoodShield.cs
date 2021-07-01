using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialShields.Instances
{
    public class DarkwoodShield : Template
    {
        public static readonly Guid ID = Guid.Parse("dd440152-bdc9-427b-94e0-68874ac11480");

        protected override PreciousMaterialShield GetShield()
        {
            return new PreciousMaterialShield
            {
                Id = ID,
                Name = "Darkwood",
                MaterialId = PreciousMaterials.Instances.Darkwood.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1453647c-b04b-487c-b8ca-7b2e2f8b1dde"), Type = TextBlockType.Text, Text = "Darkwood shields are 1 Bulk lighter than normal (or light Bulk if their normal Bulk is 1, with no effect on a shield that normally has light Bulk)." };
        }

        protected override IEnumerable<PreciousMaterialShieldVariant> GetVariants()
        {
            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("e1b024fa-ad60-4b8f-a0a2-f97c551446c6"),
                Name = "Buckler",
                CraftRequirements = "Darkwood worth at least 50 gp.",
                Price = 40000,
                ItemLevel = 8,
                Hardness = 3,
                HitPoints = 12,
                BrokenThreshold = 6,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("08c5ad8c-46c6-4d0d-b817-04b74d055ad8"),
                Name = "Shield",
                CraftRequirements = "Darkwood worth at least 55 gp.",
                Price = 44000,
                Hardness = 5,
                HitPoints = 20,
                BrokenThreshold = 10,
                ItemLevel = 8,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("3bb7e425-a668-46cd-bf35-9ebaaa7506f5"),
                Name = "Tower Shield",
                CraftRequirements = "Darkwood worth at least 70 gp.",
                Price = 56000,
                Hardness = 5,
                HitPoints = 20,
                BrokenThreshold = 10,
                ItemLevel = 8,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
                BulkId = Bulks.Instances.ThreeBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("494eeb57-5372-48c0-b722-3b59cabfed66"),
                Name = "Buckler",
                CraftRequirements = "Darkwood worth at least 4,000 gp.",
                Price = 800000,
                Hardness = 6,
                HitPoints = 24,
                BrokenThreshold = 12,
                ItemLevel = 16,
                GradeId = ItemGrades.Instances.HighGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("df79c6b1-ccfe-4b1e-b61d-27b0212049c9"),
                Name = "Shield",
                CraftRequirements = "Darkwood worth at least 4,400 gp.",
                Price = 880000,
                Hardness = 8,
                HitPoints = 32,
                BrokenThreshold = 16,
                ItemLevel = 16,
                GradeId = ItemGrades.Instances.HighGrade.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            };

            yield return new PreciousMaterialShieldVariant
            {
                Id = Guid.Parse("54da542d-c71c-4c11-bbf3-051af9d5c737"),
                Name = "Tower Shield",
                CraftRequirements = "Darkwood worth at least 5,600 gp.",
                Price = 1120000,
                Hardness = 8,
                HitPoints = 32,
                BrokenThreshold = 16,
                ItemLevel = 16,
                GradeId = ItemGrades.Instances.HighGrade.ID,
                BulkId = Bulks.Instances.ThreeBulk.ID
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
                Id = Guid.Parse("33e7a14c-b7a3-422e-b125-6189c7c3641e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 586
            };
        }
    }
}
