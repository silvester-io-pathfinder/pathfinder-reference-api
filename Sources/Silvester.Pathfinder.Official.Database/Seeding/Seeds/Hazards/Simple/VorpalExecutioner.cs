using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class VorpalExecutioner : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("3594dc7a-7749-4a92-8b2c-0dbe0ece4ce0");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Vorpal Executioner",
                Description = "A wickedly sharp saw blade descends and travels along grooves in a complex path throughout the room, attempting to decapitate everyone within.",
                Level = 19,
                ArmorClass = 43,
                Fortitude = 32,
                Reflex = 32,
                Reset = "The trap resets over the course of the round and can be triggered again 1 round later.",
                CanBeDetectedMagically = false,
                TypeId = seeder.GetHazardTypeByName("Traps").Id,
                ComplexityId = seeder.GetComplexityByName("Simple").Id
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents(HazardSeeder seeder)
        {
            yield return new HazardComponent
            {
                Name = "Per Junction",
                Hardness = 30,
                HitPoints = 120,
                BrokenThreshold = 60
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
                Id = Guid.Parse("6394bcae-4701-476c-81a6-c154f616ddb5"),
                Name = "Total Decapitation",
                Trigger = "A creature attempts to exit the room",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                EffectDetails =
                {
                    new HazardActionEffectBlock { Id = Guid.Parse("23e284eb-40a6-4934-8d0a-88b4a0c0e23c"), Text = "The saw blade travels along its path, making one Strike against each creature in the room, twisting and varying its height for a maximum chance of beheading its targets." },
                },
                Effects =
                {
                    new AttackHazardActionEffect
                    {
                        Id = Guid.Parse("a1c733d6-f608-4f7a-b8a0-3e7866285f77"),
                        Traits = seeder.FilterTraits("Death", "Deadly"),
                        Addendum = "The attack gains an additional d12 damage on critical hits due to its Deadly trait.",
                        AttackTypeId = seeder.GetAttackTypeByName("Melee").Id,
                        ActionTypeId = seeder.GetActionTypeByName("No Action").Id,
                        DamageTypeId = seeder.GetDamageTypeByName("Slashing").Id,
                        Damage = "6d12+26",
                        Weapon = "Saw Blade",
                        ProficiencyBonus = 40
                    },
                    new OtherHazardActionEffect
                    {
                        Id = Guid.Parse("f60eac7a-76ae-4793-9298-e1eac798b176"),
                        Effect = "On a critical hit, a target must succeed at a DC 39 Fortitude save or be decapitated, dying instantly unless it can survive without a head"
                    }
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("59d15c2b-1c2b-4f02-a03c-4b52d1dd6572"),
                RequiredProficiencyId = seeder.GetProficiencyByName("Expert").Id,
                DifficultyCheck = 43
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("6c4b294a-6018-43f7-8b64-35bd2710d641"),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Expert").Id,
                Description = "at four different junctions to jam all the saw blade's possible paths, preventing it from traveling through the room.",
                DifficultyCheck = 41
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
                Id = Guid.Parse("ca2171bd-fde9-4caf-9dd4-6f9ddc14ff5e"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 525
            };
        }
    }
}
