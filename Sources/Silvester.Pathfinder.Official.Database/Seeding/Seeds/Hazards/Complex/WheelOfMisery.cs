using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Complex
{
    public class WheelOfMisery : Template
    {
        public static readonly Guid ID = Guid.Parse("5f206ecc-b2a0-473c-9e09-561e7909787c");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Wheel of Misery",
                Description = "An ornate wheel set into a wall—divided into six segments with colored runes on each—is controlled by a magical sensor that detects any creature within 100 feet in front of it.",
                Level = 6,
                ArmorClass = 24,
                Fortitude = 15,
                Reflex = 13,
                Reset = "The trap deactivates and resets if 1 minute passes without any creature moving within range of its sensor.",
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Complex.ID,
                RoutineActions = 2 
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("21a8c0ca-c205-426c-926e-c9dcbccb8e73"),
                Name = "Wheel",
                Hardness = 14,
                HitPoints = 56,
                BrokenThreshold = 28,
            };
        }

        protected override IEnumerable<Guid> GetImmunities()
        {
            yield return HazardImmunities.Instances.CriticalHits.ID;
            yield return HazardImmunities.Instances.ObjectImmunities.ID;
            yield return HazardImmunities.Instances.PrecisionDamage.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Complex.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Mechanical.ID;
            yield return Traits.Instances.Trap.ID;
        }

        protected override IEnumerable<TextBlock> GetRoutineDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("417e2e47-e956-49d4-b01e-82da90ed3027"), Type = TextBlockType.Text, Text = "On its initiative, the trap uses its first action to spin, then stops. Roll 1d6 to determine which segment is topmost when the wheel stops spinning. The wheel uses its second action to replicate the spell listed for that segment (3rd level, DC 24, spell attack roll +14). This spell’s target is centered on or otherwise includes the nearest creature in the area. This increases the spell’s range to 100 feet if necessary. Any spell cast by this trap is arcane." };
            yield return new TextBlock { Id = Guid.Parse("9e4955f6-7270-4de7-ad78-8f728b8a4e57"), Type = TextBlockType.Enumeration, Text = "Sleep" };
            yield return new TextBlock { Id = Guid.Parse("35c80760-aec4-41ba-a3d3-e256796bd457"), Type = TextBlockType.Enumeration, Text = "Paralyze" };
            yield return new TextBlock { Id = Guid.Parse("c0e914be-277a-4cd2-a30a-ecdb53d8f2c6"), Type = TextBlockType.Enumeration, Text = "Lightning Bolt (100-foot line)" };
            yield return new TextBlock { Id = Guid.Parse("22e59604-b410-4183-820b-2dcfff400a8c"), Type = TextBlockType.Enumeration, Text = "Blindness" };
            yield return new TextBlock { Id = Guid.Parse("9aea181f-b676-4651-a636-710699c43495"), Type = TextBlockType.Enumeration, Text = "Acid Arrow" };
            yield return new TextBlock { Id = Guid.Parse("2fdfb966-1fa4-4286-9409-8c415686c09e"), Type = TextBlockType.Enumeration, Text = "Ray of Enfeeblement" };
        }

        protected override IEnumerable<HazardAction> GetActions()
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("29a2a4fe-936b-4b1a-8aa0-bd1e6ca3fc88"),
                Name = "Wheel Spin",
                Trigger = "A creature enters the sensor's detection area",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Details =
                {
                    new TextBlock { Id = Guid.Parse("78b61a1b-9b9c-4637-a632-d5cac2d621b6"), Type = Utilities.Text.TextBlockType.Text, Text = "The wheel begins to spin and rolls initiative." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("e8269934-560f-4d2d-bbf8-cea756614569"),
                Addendum = "to detect the magical sensor; noticing the wheel has a DC of 0.",
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                DifficultyCheck = 16
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("4b89222c-71f3-4697-ae14-620c0fa0263b"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                Description = "on the wheel to stop it from spinning",
                DifficultyCheck = 26
            };

            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("9664f9d2-c3f3-4a80-80fa-5c172bf90216"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Master.ID,
                Description = "to erase each rune",
                DifficultyCheck = 22
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements()
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("030bed99-367b-4301-8363-e76703d4efb3"),
                Level = 4,
                Description = "to counteract each rune",
                CounteractDifficultyCheck = 22
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("742d1efd-6216-4bc1-bbef-e05a55a90fcf"),
                SourceId = CoreRulebook.ID,
                Page = 527
            };
        }
    }
}
