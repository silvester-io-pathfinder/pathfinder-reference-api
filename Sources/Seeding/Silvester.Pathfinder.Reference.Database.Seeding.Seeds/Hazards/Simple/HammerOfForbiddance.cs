using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineAttacks;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Hazards.Simple
{
    public class HammerOfForbiddance : Template
    {
        public static readonly Guid ID = Guid.Parse("d88ecdc0-c9bd-4a42-8409-a215f4a5c034");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Hammer of Forbiddance",
                Description = "An enormous hammer at an edifice's entrance swings down in an attempt to damage a creature entering an area, push it back, and prevent it from going any further.",
                Level = 11,
                ArmorClass = 32,
                Fortitude = 24,
                Reflex = 15,
                Reset = "The trap resets over the course of the round, and is ready to swing again 1 round later.",
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Simple.ID
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("3d2b0564-6171-438a-850b-329c7e33b072"),
                Name = "Hammer",
                HitPoints = 88,
                Hardness = 22,
                BrokenThreshold = 44,
            };

            yield return new HazardComponent
            {
                Id = Guid.Parse("363a661a-06ba-4d70-ab3d-dc1156c964be"),
                Name = "Joint",
                HitPoints = 64,
                Hardness = 16,
                BrokenThreshold = 32,
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
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Mechanical.ID;
            yield return Traits.Instances.Trap.ID;
        }

        protected override void GetActions(InlineActionCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("2eb1837d-c49c-447e-98d7-b30c858912f0"), ActionTypes.Instances.Reaction.ID, "Forbid Entry", action =>
            {
                action
                    .Trigger("A creature attempts to enter through the entrance.")
                    .Frequency("")
                    .Requirements("")
                    .Traits(traits =>
                    {
                        traits.Add(Guid.Parse("67bad618-9923-4170-b31a-3bca961dc3e6"), Traits.Instances.Abjuration.ID);
                        traits.Add(Guid.Parse("34db5ac2-0c5d-41de-8a7b-d09cc69b8e17"), Traits.Instances.Divine.ID);
                    })
                    .Details(details =>
                    {
                        details.Text(Guid.Parse("356c9040-4be1-4428-a454-8e39c037da0c"), "The hammer swings down, making a Strike against the triggering creature.");
                    });
            });
        }

        protected override void GetAttacks(InlineAttackCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("12bd4ee5-1bb3-406a-845b-be5e69a7f94b"), AttackTypes.Instances.Melee.ID, ActionTypes.Instances.NoAction.ID, "Hammer", hitModifier: 28, "6d8+20", DamageTypes.Instances.Bludgeoning.ID, attack =>
            {
                attack.Details(details =>
                {
                    details.Text(Guid.Parse("652e76e1-bd30-42f3-ae57-156b343349f5"), "The target is knocked back 10 feet and must succeed at a DC 30 Will save or be unable to enter the edifice through any entrance for 24 hours (on a critical hit, the target automatically fails the Will save); no multiple attack penalty.");
                });
            });
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("9c5b1455-5d22-4b85-baee-aa7a7e9aabd9"),
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                DifficultyCheck = 30
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("b477f38d-c91a-44c7-9095-7e6e9c52d81d"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                Description = "Once on the hammer itself and once on its joint to prevent the hammer from swinging.",
                DifficultyCheck = 28
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
                Id = Guid.Parse("7fe355f0-54eb-46b1-9472-7d4a53a4db08"),
                SourceId = CoreRulebook.ID,
                Page = 525
            };
        }
    }
}
