using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class ScytheBlades : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("b658c798-2ef4-4040-9980-7828bbeeb523");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Scythe Blades",
                Description = "Two blades, each hidden in a 15-foot-long ceiling groove, are both connected to a trip wire.",
                Level = 4,
                ArmorClass = 21,
                Fortitude = 12,
                Reflex = 8,
                Reset = "The trap resets after 15 minutes.",
                CanBeDetectedMagically = false,
                TypeId = seeder.GetHazardTypeByName("Traps").Id,
                ComplexityId = seeder.GetComplexityByName("Simple").Id
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents(HazardSeeder seeder)
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("f86b81de-3078-4de8-9ad0-ab30250b4df5"),
                Name = "Blades",
                HitPoints = 44,
                Hardness = 11,
                BrokenThreshold = 22,
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
                Id = Guid.Parse("574be793-dfaa-4b21-ac86-4c65fd08bd92"),
                Name = "Falling Scytehs",
                Trigger = "The trip wire is pulled or severed",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("99511947-964d-4238-bba3-e8f5c44be0b4"),Type = TextBlockType.Text,  Text = "Both blades swing down, each one Striking all creatures under the ceiling grooves." },
                },
                Effects =
                {
                     new AttackHazardActionEffect
                     {
                        Id = Guid.Parse("17da5f2f-ccb6-4f45-aa51-f6f2807d4a15"),
                        AttackTypeId = seeder.GetAttackTypeByName("Melee").Id,
                        ActionTypeId = seeder.GetActionTypeByName("No Action").Id,
                        DamageTypeId = seeder.GetDamageTypeByName("Slashing").Id,
                        Addendum = "The attack suffers no multiple attack penalty, and adds 1d12 damage on critical hits due to its Deadly trait.",
                        Traits = seeder.FilterTraits("Deadly"),
                        Damage = "2d12+4",
                        Weapon = "Scythe",
                        ProficiencyBonus = 17
                     },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("896ea8f0-24b3-4532-81a3-b7a8f1edcbcd"),
                RequiredProficiencyId = seeder.GetProficiencyByName("Trained").Id,
                DifficultyCheck = 23
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("859314b5-6c92-43b6-964b-fad36bd66f0f"),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Trained").Id,
                Description = "to disable each blade",
                DifficultyCheck = 21
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
                Id = Guid.Parse("719ab320-45f1-4057-aaea-11055889b36a"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 523
            };
        }
    }
}
