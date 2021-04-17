using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class PlanarRift : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("d038f033-4ea9-45ee-b0fa-c5707d5eda89");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Planar Rift",
                Description = "A rift attempts to draw creatures into another plane(the GM chooses the specific plane).",
                Level = 13,
                CanBeDetectedMagically = false,
                TypeId = seeder.GetHazardTypeByName("Traps").Id,
                ComplexityId = seeder.GetComplexityByName("Simple").Id
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents(HazardSeeder seeder)
        {
            yield break;
        }

        protected override IEnumerable<string> GetImmunities()
        {
            yield break;
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Magical";
            yield return "Trap";
        }

        protected override IEnumerable<HazardAction> GetActions(HazardSeeder seeder)
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("c2534177-226c-402f-aae3-bc40111eed8d"),
                Name = "Into the Great Beyond",
                Traits = seeder.FilterTraits("Conjuration", "Occult", "Teleportation"),
                Trigger = "A creature moves within 10 feet of the rift",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                EffectDetails =
                {
                    new HazardActionEffectBlock { Id = Guid.Parse("ae24d667-ccda-431a-a998-7e754abfee8e"), Text = "The triggering creature and all creatures within 30 feet of the rift are drawn into another plane. Each creature can attempt a DC 33 Reflex save to avoid this fate." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("b2d72108-a773-409c-a190-793667d2ba60"),
                RequiredProficiencyId = seeder.GetProficiencyByName("Trained").Id,
                DifficultyCheck = 35
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("4c0d2ac8-48f8-4612-b8ab-72db8b4aa831"),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Master").Id,
                Description = "to assemble a rift seal using objects strongly grounded to your plane",
                DifficultyCheck = 33
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements(HazardSeeder seeder)
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("4c0d2ac8-48f8-4612-b8ab-72db8b4aa831"),
                Level = 7,
                Description = "to counteract the rift",
                CounteractDifficultyCheck = 31
            };
        }

        protected override SourcePage GetSourcePage(HazardSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c0d2ac8-48f8-4612-b8ab-72db8b4aa831"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 525
            };
        }
    }
}
