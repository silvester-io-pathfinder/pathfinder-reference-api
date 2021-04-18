using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class HallucinationPowderTrap : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("cb9ff968-3115-412d-8f69-86b73d9a20c9");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Hallucination Powder Trap",
                Description = "A tube of hallucinogenic powder armed with a miniature explosive is connected to a doorknob or similar latch.",
                Level = 6,
                ArmorClass = 24,
                Fortitude = 0,
                Reflex = 0,
                
                CanBeDetectedMagically = false,
                TypeId = seeder.GetHazardTypeByName("Traps").Id,
                ComplexityId = seeder.GetComplexityByName("Simple").Id
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents(HazardSeeder seeder)
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("36cf0609-a973-4ce7-b5c4-8b32d2b4adb3"),
                Name = "Trap",
                HitPoints = 1,
                Hardness = 0
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
                Id = Guid.Parse("3df56b95-79f0-4ed7-bdb0-d0d0bdddcde2"),
                Name = "Powder Burst",
                Traits = seeder.FilterTraits("Mental", "Poison"),
                Trigger = "The latch is opened or the tube is broken",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("06f5fbcf-7e70-4444-8f61-60927a67cef8"),Type = TextBlockType.Text,  Text = "The tube explodes, spraying hallucinogenic powder in a 30-foot cone. Any creature in the cone must succeed at a DC 24 Will save or be confused for 1 round and take a –2 status penalty to Perception checks and saves against mental effects for 1d4 hours. On a critical failure, the penalty is instead –4." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("88bf4475-33a1-43c8-bf6f-3286818a211d"),
                RequiredProficiencyId = seeder.GetProficiencyByName("Expert").Id,
                DifficultyCheck = 24
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("b6283717-721c-4280-9a7e-5a1ec2b2ec85"),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Expert").Id,
                Description = "to disable the hammer that strikes the percussion cap",
                DifficultyCheck = 26
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
                Id = Guid.Parse("a5a01655-41be-4e84-b464-fe3a76e4d1bd"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 524
            };
        }
    }
}
