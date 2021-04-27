using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class HiddenPit : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("6d810cbc-bf1f-4232-9517-cbb95e4b5a33");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Hidden Pit",
                Description = "A wooden trapdoor covers a pit that’s 10 feet square and 20 feet deep.",
                Level = 0,
                ArmorClass = 10,
                Fortitude = 1,
                Reflex = 1,
                Reset = "Creatures can still fall into the trap, but the trapdoor must be reset manually for the trap to become hidden again.",
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Simple.ID
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("807c4594-4f71-4ce5-828f-232678a7b1f6"),
                Name = "Trapdoor",
                HitPoints = 12,
                Hardness = 3,
                BrokenThreshold = 6,
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
            yield return Traits.Instances.Mechanical.ID;
            yield return Traits.Instances.Trap.ID;
        }

        protected override IEnumerable<HazardAction> GetActions()
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("a2bfaa34-76eb-43d8-a990-32b7437d8304"),
                Name = "Pitfall",
                Trigger = "A creature walks onto the trapdoor",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("21077b3a-26c5-4556-b3e5-b48e4970f323"), Type = TextBlockType.Text, Text = "The triggering creature falls in and takes falling damage (typically 10 bludgeoning damage). That creature can use the Grab an Edge reaction to avoid falling." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("2a2bf76d-3387-4400-b569-ee512180a409"),
                Addendum = "If the trapdoor is disabled or broken, the Difficulty Check becomes 0.",
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID,
                DifficultyCheck = 18
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("1e0d3792-40ea-4884-921c-58305f558677"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID,
                Description = "to remove the trapdoor",
                DifficultyCheck = 12
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
                Id = Guid.Parse("3bcc0fe0-0f4c-4d25-99e3-32db6fdfe7d1"),
                SourceId = CoreRulebook.ID,
                Page = 522
            };
        }
    }
}
