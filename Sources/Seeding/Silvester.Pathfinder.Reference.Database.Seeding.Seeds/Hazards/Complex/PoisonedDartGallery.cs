using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineAttacks;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Hazards.Complex
{
    public class PoisonedDartGallery : Template
    {
        public static readonly Guid ID = Guid.Parse("d609d826-9840-4418-a0a4-9a9531e09f17");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Poisoned Dart Gallery",
                Description = "Countless holes to launch poison darts from line a long hallway with a hidden control panel on the far end.",
                Level = 8,
                ArmorClass = 27,
                Fortitude = 13,
                Reflex = 17,
                Reset = "The trap deactivates and resets after 1 minute.",
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Complex.ID,
                RoutineActions = 1
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("8357fbb6-72b5-426f-a715-b1f3d9eb5344"),
                Name = "Control Panel",
                Hardness = 14,
                HitPoints = 56,
                BrokenThreshold = 28,
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
            yield return Traits.Instances.Complex.ID;
            yield return Traits.Instances.Mechanical.ID;
            yield return Traits.Instances.Trap.ID;
        }

        protected override IEnumerable<TextBlock> GetRoutineDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("85e4e3c2-a458-4da2-851e-16f694b880cc"), Type = TextBlockType.Text, Text = "The trap launches one dart against every creature in the gallery as 1 action. Because it launches darts continuously, the trap can also use the Continuous Barrage free action (see below) to launch darts at each creature during that creature's turn." };
        }

        protected override void GetAttacks(InlineAttackCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("e1ba326b-d859-4b7a-9a89-68a591e8801a"), AttackTypes.Instances.Ranged.ID, ActionTypes.Instances.NoAction.ID, "Poisoned Dart", hitModifier: 21, "3d4", DamageTypes.Instances.Piercing.ID, attack =>
            {
                attack.StaggeredEffect(Guid.Parse("acde54a3-3dc8-4855-bd4e-eb12005c8388"), "Flesset Poison", "Immediate.", SavingThrowStats.Instances.Fortitude.ID, "6 Rounds.", effect => 
                {
                    effect
                        .DifficultyCheck(22)
                        .Traits(traits =>
                        {
                            traits.Add(Guid.Parse("f8277d83-4cb3-4090-8ea3-44637d21d7f0"), Traits.Instances.Poison.ID);
                        })
                        .Stage(Guid.Parse("c2c8231e-19f5-4d6c-914c-5187338f5f6b"), "1 Round.", stage =>
                        {
                            stage.Effect(new DamageEffect { Id = Guid.Parse("c9d62b09-91f1-4e18-bd8e-e127cd634aff"), Damage = "1d6", DamageTypeId = DamageTypes.Instances.Poison.ID });
                            stage.Effect(new ConditionEffect { Id = Guid.Parse("f1cb8577-8a8e-4a97-a540-b14550c803c9"), ConditionId = Clumsy.ID, Severity = 1 });
                        })
                        .Stage(Guid.Parse("ac19b527-86cf-439e-8843-61ab68bd2459"), "1 Round.", stage =>
                        {
                            stage.Effect(new DamageEffect { Id = Guid.Parse("044dbf8d-f3cb-4993-afe9-981f70035070"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID });
                            stage.Effect(new ConditionEffect { Id = Guid.Parse("6200804d-c0c7-4653-ba70-cbbb91cf448f"), ConditionId = Clumsy.ID, Severity = 2 });
                        })
                        .Stage(Guid.Parse("136ceb18-07f8-4abe-80f8-1e3f9880d5fb"), "1 Round.", stage =>
                        {
                            stage.Effect(new DamageEffect { Id = Guid.Parse("6f95b00b-9387-4bf5-9bda-844e25fd15c3"), Damage = "3d6", DamageTypeId = DamageTypes.Instances.Poison.ID });
                            stage.Effect(new ConditionEffect { Id = Guid.Parse("933e0675-6683-42ad-a573-5356fa3366d6"), ConditionId = Clumsy.ID, Severity = 3 });
                        });
                });
            });
        }

        protected override void GetActions(InlineActionCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("08abae5d-5e71-45ca-9a37-9d44a955d84c"), ActionTypes.Instances.Reaction.ID, "Dart Volley", action =>
            {
                action
                    .Trigger("A creature enters the hallway or ends its turn in the hallway")
                    .Details(details =>
                    {
                        details.Text(Guid.Parse("eb77450e-c55c-43e4-b3c1-aadb7c0fe4e5"), "The trap makes a poisoned dart Strike against the triggering creature, then rolls initiative.");
                    });
            });

            builder.Add(Guid.Parse("edea22d4-1f12-48a8-b1f1-b6ee4de1b4f7"), ActionTypes.Instances.FreeAction.ID, "Continuouos Barrage", action => 
            {
                action
                    .Trigger("A creature within the active gallery finishes an action.")
                    .Details(effect => 
                    {
                        effect.Text(Guid.Parse("f79173f5-49dc-4322-8be4-c4591b89d643"), "The trap makes a poisoned dart Strike against the triggering creature.");
                    });
            });
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("f98c8688-0bca-42e8-8cbb-749ae7a2966c"),
                Addendum = "The DC to notice the control panel is 31 and requires the Master proficiency.",
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                DifficultyCheck = 16
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("cd624827-5366-4462-be3e-07d2bcfdf8f4"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                Description = "on the control panel deactivates the trap",
                DifficultyCheck = 21
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
                Id = Guid.Parse("800680a3-465d-4099-b20a-b66da308da97"),
                SourceId = CoreRulebook.ID,
                Page = 528
            };
        }
    }
}
