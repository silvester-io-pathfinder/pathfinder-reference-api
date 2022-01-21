using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineAttacks;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Hazards.Simple
{
    public class PoisonedLock : Template
    {
        public static readonly Guid ID = Guid.Parse("5f593e05-0197-4c12-9102-84501831aaf0");

        protected override Hazard GetHazard()
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
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Simple.ID,
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("2454c5a3-613e-4cfc-9850-6bc884da0b2d"),
                Name = "Trap",
                HitPoints = 24,
                Hardness = 6,
                BrokenThreshold = 12,
            };
        }

        protected override IEnumerable<Guid> GetImmunities()
        {
            yield return Immunities.Instances.CriticalHits.ID;
            yield return Immunities.Instances.ObjectImmunities.ID;
            yield return Immunities.Instances.PrecisionDamage.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Mechanical.ID;
            yield return Traits.Instances.Trap.ID;
        }

        protected override void GetActions(InlineActionCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("09a54c43-77a9-42c6-a041-aab4c55df5ff"), ActionTypes.Instances.Reaction.ID, "Spring", action =>
            {
                action
                    .Trigger("A creature tries to unlock or Pick the Lock.")
                    .Details(details =>
                    {
                        details.Text(Guid.Parse("5ca24113-9fa9-4802-92db-bf378e003180"), "A spine extends to Strike the triggering creature.");
                    });
            });
        }

        protected override void GetAttacks(InlineAttackCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("d4ad0941-c5d9-4d98-a3f4-f9483a4fb564"), AttackTypes.Instances.Melee.ID, ActionTypes.Instances.NoAction.ID, "Spine", hitModifier: 13, "1", DamageTypes.Instances.Piercing.ID, attack => 
            {
                attack.StaggeredEffect(Guid.Parse("3d21bed5-94f4-45b8-82c2-3f42be0502ca"), "Cladis Poison", "Immediate.", SavingThrowStats.Instances.Fortitude.ID, "4 hours.", effect =>
                {
                    effect
                        .DifficultyCheck(19)
                        .Traits(traits =>
                        {
                            traits.Add(Guid.Parse("a1c747f9-ced1-4c1b-a629-d3ab27c3db62"), Traits.Instances.Poison.ID);
                        })
                        .Stage(Guid.Parse("c7bf68d5-f424-463a-9d2d-fe79b9153382"), "1 Hour.", stage =>
                        {
                            stage.Effect(new DamageEffect { Id = Guid.Parse("acd30942-2ef7-48f0-b1f7-88a3e3ba6501"), Damage = "1d6", DamageTypeId = DamageTypes.Instances.Poison.ID });
                            stage.Effect(new ConditionEffect { Id = Guid.Parse("0439dbdb-3e95-46d8-8d92-20fe516b3676"), ConditionId = Drained.ID, Severity = 1 });
                        })
                        .Stage(Guid.Parse("1f990df0-d8c5-4f4b-afc7-99fed29d5f2a"), "1 Hour.", stage =>
                        {
                            stage.Effect(new DamageEffect { Id = Guid.Parse("df9f86d2-61cf-465b-897c-83374a1f1cd1"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID });
                            stage.Effect(new ConditionEffect { Id = Guid.Parse("87146bef-d285-4709-be49-23f0f938f2e8"), ConditionId = Drained.ID, Severity = 2 });
                        })
                        .Stage(Guid.Parse("77f57fd3-ba22-4640-9eb0-2b3c5dfc96e7"), "1 Hour.", stage =>
                        {
                            stage.Effect(new DamageEffect { Id = Guid.Parse("948bb72f-eb12-4dde-942d-f05fd77c83a3"), Damage = "3d6", DamageTypeId = DamageTypes.Instances.Poison.ID });
                            stage.Effect(new ConditionEffect { Id = Guid.Parse("61ce8bd6-8df5-4715-a23f-27379c6601bf"), ConditionId = Drained.ID, Severity = 2 });
                        });
                });
            });
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("e00e6998-3b26-4b06-a024-34534da52538"),
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                DifficultyCheck = 17
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("5dee5085-d947-4cad-8d8a-794d6ac56790"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                Description = "On the spring mechanism.",
                DifficultyCheck = 17
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("53f23a87-1e51-4eff-9c24-3a68f6f1a3e8"),
                SourceId = CoreRulebook.ID,
                Page = 522
            };
        }
    }
}
