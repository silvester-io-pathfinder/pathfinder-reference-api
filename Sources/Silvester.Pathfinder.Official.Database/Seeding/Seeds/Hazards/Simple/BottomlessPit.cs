using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class BottomlessPit : Template
    {
        public static readonly Guid ID = Guid.Parse("3ad83166-b025-4e40-8e25-f82778e35c0b");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Bottomless Pit",
                Description = "An iron trapdoor covers an infinitely deep 10 - foot - square pit.",
                Level = 9,
                ArmorClass = 28,
                Fortitude = 12,
                Reflex = 12,
                Reset = "The trap still causes creatures to fall forever if they fall in, but the trapdoor must be reset manually for the trap to become hidden again.",
                CanBeDetectedMagically = true,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Simple.ID
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("d7c44691-32d2-4f86-819c-9d996b136c48"),
                Name = "Trapdoor",
                HitPoints = 36,
                Hardness = 9,
                BrokenThreshold = 18,
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

        protected override IEnumerable<HazardAction> GetActions()
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("54b9c0cb-563f-412d-aa62-829de3b015c5"),
                Name = "Infinite Pitfall",
                Trigger = "A creature walks onto the trapdoor",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("63bd40ef-eda7-4641-8d14-e4cd5efbfbaf"), Type = TextBlockType.Text, Text = "The triggering creature falls in and continues to fall, potentially forever. That creature can try to Grab an Edge to avoid falling (page 472). The DC to Climb the walls or Grab an Edge is 26" },
                    new TextBlock { Id = Guid.Parse("3b3bacc8-6bac-46c7-afff-17183a183c5a"), Type = TextBlockType.Text, Text = "The pit contains many handholds, so the falling creature can try to Grab an Edge again every 6 seconds. If the creature succeeds, it can start to Climb out from that point (though it might be a very long climb, depending on how far the creature fell). Since the creature falls endlessly, it can rest and even prepare spells while falling, though items dropped while falling are usually lost forever." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("8984fb7e-078f-4a2b-8db0-d373dcb044e6"),
                Addendum = "The DC for detection becomes 0 if the trapdoor is disabled or broken.",
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID,
                DifficultyCheck = 30
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("c95a878d-b931-44dc-b7bb-8ab9b0318774"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                Description = "to remove the trapdoor",
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
                Id = Guid.Parse("6ac226b9-1707-407a-b1cf-b5dce0b967ff"),
                SourceId = CoreRulebook.ID,
                Page = 524
            };
        }
    }
}
