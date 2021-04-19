using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class SpearLauncher : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("9acfc457-78d5-4af1-a8b1-a09f9f2d8312");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Spear Launcher",
                Description = "A wall socket loaded with a spear connects to a floor tile in one 5-foot square.",
                Level = 2,
                ArmorClass = 18,
                Fortitude = 11,
                Reflex = 3,
                CanBeDetectedMagically = false,
                TypeId = seeder.GetHazardTypeByName("Traps").Id,
                ComplexityId = seeder.GetComplexityByName("Simple").Id
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents(HazardSeeder seeder)
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("1b7f63e1-843d-42c6-b2a4-76372dd89691"),
                Name = "Pressure Plate",
                HitPoints = 32,
                Hardness = 8,
                BrokenThreshold = 16,
            };
        }

        protected override IEnumerable<string> GetImmunities()
        {
            yield return "Critical Hits";
            yield return "Object Immunities";
            yield return "Precision Damage";
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Mechanical";
            yield return "Trap";
        }

        protected override IEnumerable<HazardAction> GetActions(HazardSeeder seeder)
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("09e804f4-5f1b-4255-b1d1-31e90811b52a"),
                Name = "Spear",
                Trigger = "Pressure is applied to the floor tile",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("fd11a9dd-3a82-4d6f-9861-62c108f617a5"),Type = TextBlockType.Text,  Text = "The trap shoots a spear, making a Strike against the creature or object on the floor tile." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("d1d73ba4-1649-4e87-a432-7d469bea997c"),
                RequiredProficiencyId = seeder.GetProficiencyByName("Trained").Id,
                DifficultyCheck = 20
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("14f6268a-0806-45c2-8150-5967912b2e24"),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Trained").Id,
                Description = "on the floor tile or wall socket",
                DifficultyCheck = 18
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements(HazardSeeder seeder)
        {
            yield break;
        }

        protected override SourcePage GetSourcePage(HazardSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca5b006a-8d72-4b2f-827b-09a48cd3b690"),
                SourceId = CoreRulebook.ID,
                Page = 523
            };
        }
    }
}
