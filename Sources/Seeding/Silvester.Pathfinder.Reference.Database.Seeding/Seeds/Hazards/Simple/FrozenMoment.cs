using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Hazards.Simple
{
    public class FrozenMoment : Template
    {
        public static readonly Guid ID = Guid.Parse("a6c694f4-7246-4eb0-8cf9-382017a73fad");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Frozen Moment",
                Description = "Warding magic attempts to trap intruders or would - be thieves in a disrupted time flow.",
                Level = 17,
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Simple.ID
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetImmunities()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Trap.ID;
        }

        protected override IEnumerable<HazardAction> GetActions()
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("21a56455-6731-4be9-bc6b-02130bac5957"),
                Name = "Adrift in Time",
                Traits = FilterTraits("Occult", "Transmutation"),
                Trigger = "A creature touches the warded object or area",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("806735c8-382d-4647-a8fd-b33e379cebad"), Type = TextBlockType.Text, Text = "The triggering creature and all creatures within 30 feet are trapped in a disrupted time flow (DC 38 Fortitude negates). The creatures' minds move so quickly that each round seems to last a century, but their bodies and magical energies move so slowly that they can't use any actions except Recall Knowledge. An affected creature must attempt a DC 36 Will saving throw against a warp mind spell immediately and again for every minute of real time that passes while the creature is trapped in the frozen moment. This effect has an unlimited duration but can be counteracted." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("ac65acb9-87f9-490b-91e8-b80d3943349f"),
                RequiredProficiencyId = Proficiencies.Instances.Master.ID,
                DifficultyCheck = 30
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("f5a17566-7306-40d5-b07f-f7152470593d"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Legendary.ID,
                Description = "To rapidly disassemble the spell's myriad components in a single blink of an eye.",
                DifficultyCheck = 38
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements()
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("bb9a1fb9-c343-46e0-a7dc-dcdd239b6107"),
                Level = 8,
                Description = "To counteract the trap before it triggers or to counteract the effect on one creature after the trap is triggered.",
                CounteractDifficultyCheck = 36
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9217066-3a54-4767-ae52-5eaf6a8f4f28"),
                SourceId = CoreRulebook.ID,
                Page = 525
            };
        }
    }
}
