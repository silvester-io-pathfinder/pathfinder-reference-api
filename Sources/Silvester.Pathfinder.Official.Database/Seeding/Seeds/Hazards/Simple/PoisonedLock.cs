using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class PoisonedLock : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Poisoned Lock",
                Description = "A spring-loaded, poisoned spine is hidden near the keyhole of a lock. Disabling or breaking the trap does not disable or break the lock.",
                Level = 1,
                ArmorClass = 15,
                Fortitude = 8,
                Reflex = 4,
                HitPoints = 24,
                Hardness = 6,
                BrokenThreshold = 12,
                CanBeDetectedMagically = false,
                TypeId = seeder.GetHazardTypeByName("Traps").Id,
                ComplexityId = seeder.GetComplexityByName("Simple").Id,
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

        protected override HazardAction GetActions(HazardSeeder seeder)
        {
            return new HazardAction
            {
                Id = Guid.Parse(""),
                Name = "Spring",
                Effect = "A spine extends to Strike the triggering creature.",
                Trigger = "A creature tries to unlock or Pick the Lock.",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                Effects = new HazardActionEffect[] 
                {
                    new AttackHazardActionEffect
                    {
                        Id = Guid.Parse(""),
                        AttackTypeId = seeder.GetAttackTypeByName("Melee").Id,
                        ActionTypeId = seeder.GetActionTypeByName("No Action").Id,
                        DamageTypeId = seeder.GetDamageTypeByName("Poercing").Id,
                        Damage = "1",
                        Weapon = "Spine",
                        ProficiencyBonus = 13
                    },
                    new PoisonHazardActionEffect
                    {
                        Id = Guid.Parse(""),
                        Name = "Cladis Poison",
                        PoisonEffect = new PoisonEffect
                        {
                            Id = Guid.Parse(""),
                            Traits = seeder.FilterTraits("Poision"),
                            SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                            MaximumDuration = "4 Hours",
                            Stages = 
                            {
                                new PoisonEffectStage
                                {
                                    Id = Guid.Parse(""),
                                    Duration = "1 Hour",
                                    Effects =
                                    {
                                        new DamagePoisonStageEffect {Id = Guid.Parse(""), Damage = "1d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id },
                                        new ConditionPoisonStageEffect { Id = Guid.Parse(""), ConditionId = Drained.ID, Severity = 1}
                                    }
                                },
                                new PoisonEffectStage
                                {
                                    Id = Guid.Parse(""),
                                    Duration = "1 Hour",
                                    Effects =
                                    {
                                        new DamagePoisonStageEffect {Id = Guid.Parse(""), Damage = "2d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id },
                                        new ConditionPoisonStageEffect { Id = Guid.Parse(""), ConditionId = Drained.ID, Severity = 2}
                                    }
                                },
                                new PoisonEffectStage
                                {
                                    Id = Guid.Parse(""),
                                    Duration = "1 Hour",
                                    Effects =
                                    {
                                        new DamagePoisonStageEffect {Id = Guid.Parse(""), Damage = "3d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id },
                                        new ConditionPoisonStageEffect { Id = Guid.Parse(""), ConditionId = Drained.ID, Severity = 2}
                                    }
                                },
                            }
                        }
                    }
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse(""),
                RequiredProficiencyId = seeder.GetProficiencyByName("Trained").Id,
                DifficultyCheck = 17
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse(""),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Trained").Id,
                Description = "on the spring mechanism",
                DifficultyCheck = 17
            };
        }
    }
}
