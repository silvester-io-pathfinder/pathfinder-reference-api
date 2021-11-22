using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Hazards.Complex
{
    public class SpinningBladePillar : Template
    {
        public static readonly Guid ID = Guid.Parse("e417fa19-f7e3-4372-988e-8e2ce524e804");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Spinning Blade Pillar",
                Description = "A metal pole with three razor-sharp spinning blades is hidden in the floor, connected to trigger plates in up to eight floor tiles and a hidden control panel within 30 feet.",
                Level = 4,
                ArmorClass = 21,
                Fortitude = 10,
                Reflex = 12, 
                Reset = "The trap deactivates and resets after 1 minute.",
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Complex.ID,
                Speed = 10,
                RoutineActions = 3
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("8f90e4f4-a3b6-4419-9dad-63ff61581675"),
                Name = "Pillar",
                Hardness = 12,
                HitPoints = 48,
                BrokenThreshold = 24,
            };

            yield return new HazardComponent
            {
                Id = Guid.Parse("ee76d481-a163-409a-b298-b28ca4a919ce"),
                Name = "Panel",
                Hardness = 5,
                HitPoints = 20,
                BrokenThreshold = 10,
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
            yield return new TextBlock { Id = Guid.Parse("bb0601b7-7b22-47fc-a985-a53eccad97a2"), Type = TextBlockType.Text, Text = "The trap uses its first action to make a spinning blade Strike against each adjacent creature, its second action to move straight in a random direction (roll 1d4 to determine the direction), and its third action to make a spinning blade Strike against each adjacent creature. This trap doesn't take a multiple attack penalty." };
        }

        protected override IEnumerable<HazardAction> GetActions()
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("202a3139-430a-4841-8488-9eefbe0089fe"),
                Name = "Rising Pillar",
                Trigger = "A creature steps on one of the trapped floor tiles",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8c6ac794-a869-4f98-8fda-c9157022eb44"), Text = "The trap pops up in a grid intersection and makes a spinning blade Strike against one adjacent creature (if any), then rolls initiative." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("1e9ad9c6-6b64-456d-953b-53ca028a1212"),
                Addendum = "The DC to notice the control panel is 26 and requires a minimum proficiency of Expert.",
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                DifficultyCheck = 11
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("6dea1b71-e27d-44cd-8778-bed39f6a4d73"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                Description = "twice on the pillar to deactivate the whole trap",
                DifficultyCheck = 21
            };

            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("65eb6dd7-c29f-401e-96a0-1aabf4fba4df"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                Description = "once on the control panel to deactive the whole trap. Breakin gthe control panel prevents anyone from disabling the trap using the control panel and prevents the trap from deactivating automatically",
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
                Id = Guid.Parse("b68c5ba3-4c51-4537-a72a-f1066c6b875f"),
                SourceId = CoreRulebook.ID,
                Page = 527
            };
        }
    }
}
