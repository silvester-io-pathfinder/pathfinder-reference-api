using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class HallucinationPowderTrap : Template
    {
        public static readonly Guid ID = Guid.Parse("cb9ff968-3115-412d-8f69-86b73d9a20c9");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Hallucination Powder Trap",
                Description = "A tube of hallucinogenic powder armed with a miniature explosive is connected to a doorknob or similar latch.",
                Level = 6,
                ArmorClass = 24,
                Fortitude = 0,
                Reflex = 0,
                
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Simple.ID
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("36cf0609-a973-4ce7-b5c4-8b32d2b4adb3"),
                Name = "Trap",
                HitPoints = 1,
                Hardness = 0
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

        protected override IEnumerable<HazardAction> GetActions()
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("3df56b95-79f0-4ed7-bdb0-d0d0bdddcde2"),
                Name = "Powder Burst",
                Traits = FilterTraits("Mental", "Poison"),
                Trigger = "The latch is opened or the tube is broken",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("06f5fbcf-7e70-4444-8f61-60927a67cef8"),Type = TextBlockType.Text,  Text = "The tube explodes, spraying hallucinogenic powder in a 30-foot cone. Any creature in the cone must succeed at a DC 24 Will save or be confused for 1 round and take a –2 status penalty to Perception checks and saves against mental effects for 1d4 hours. On a critical failure, the penalty is instead –4." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("88bf4475-33a1-43c8-bf6f-3286818a211d"),
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                DifficultyCheck = 24
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("b6283717-721c-4280-9a7e-5a1ec2b2ec85"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                Description = "To disable the hammer that strikes the percussion cap.",
                DifficultyCheck = 26
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
                Id = Guid.Parse("a5a01655-41be-4e84-b464-fe3a76e4d1bd"),
                SourceId = CoreRulebook.ID,
                Page = 524
            };
        }
    }
}
