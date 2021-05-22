using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Complex
{
    public class DrowningPit : Template
    {
        public static readonly Guid ID = Guid.Parse("06b3ee8e-446d-49e5-8737-551f94484753");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Drowning Pit",
                Description = "A trapdoor covers a 10-foot-square pit that’s 30 feet deep and has 5 feet of water at the bottom. Four water spouts in the walls connect to hidden water tanks. Each water spout extends out of a different wall, 6 inches from the top of the pit.",
                Level = 3,
                ArmorClass = 19,
                Fortitude = 8,
                Reflex = 5,
                Reset = "The trap can be reset if the door is manually reengaged and the water tanks refilled; it can be reset without draining the pit, but doing so renders it less effective.",
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Complex.ID,
                RoutineActions = 4
            };
        }

        protected override IEnumerable<TextBlock> GetRoutineDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d58fd9ed-f604-45d1-ab07-65c3cc68799c"), Type = TextBlockType.Text, Text = "The trap loses 1 action each turn for each disabled water spout. On each of the trap’s actions, a spout pours water, increasing the depth of the water by 5 feet. Once the pit is full of water, the pit stops using actions, but creatures in the pit begin drowning (page 478)." };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("43590a0a-bc4f-46b3-9c5a-10533b8b164b"),
                Name = "Trapdoor",
                Hardness = 15,
                HitPoints = 60,
                BrokenThreshold = 30,
            };

            yield return new HazardComponent
            {
                Id = Guid.Parse("39da2418-679b-41c8-a861-6fd7001c52c2"),
                Name = "Spout",
                Hardness = 8,
                HitPoints = 32,
                BrokenThreshold = 16,
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

        protected override IEnumerable<HazardAction> GetActions()
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("ffe63bc7-f008-4d70-9357-e6ada9e45a25"),
                Name = "Pitfall",
                Trigger = "A creature walks onto the trapdoor",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b3fae5a4-340d-41a7-821b-80713b7affd8"), Type = Utilities.Text.TextBlockType.Text, Text = "The triggering creature falls in and takes damage from the fall, reduced by 5 feet for falling into the water (typically 12 bludgeoning damage). A creature can Grab an Edge to avoid falling (page 472). The trapdoor then slams shut, and the hazard rolls initiative." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("1422ea3a-72ec-460f-8eea-277f9ee0df98"),
                Addendum = "The DC to notive the water spouts once the pit opens is 22, and requires Expert proficiency.",
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                DifficultyCheck = 10
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("77b15943-1920-4add-8b1d-ffd953670482"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                Description = "to seal each waterspout",
                DifficultyCheck = 18
            };

            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("75797be2-cd98-4fa7-b542-03d81f397efe"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                Description = "to open the trapdoor",
                DifficultyCheck = 22
            };

            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("f63eb02e-43dc-4f77-a48a-87b37c17d55e"),
                SkillId = Skills.Instances.Athletics.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID,
                Description = "to force open the trapdoor",
                DifficultyCheck = 22
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
                Id = Guid.Parse("d08cc06e-0eb7-4f3e-b173-7dbb8dcb1b87"),
                SourceId = CoreRulebook.ID,
                Page = 526
            };
        }
    }
}
