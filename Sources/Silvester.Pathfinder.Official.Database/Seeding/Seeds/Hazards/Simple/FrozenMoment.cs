using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class FrozenMoment : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("a6c694f4-7246-4eb0-8cf9-382017a73fad");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Frozen Moment",
                Description = "Warding magic attempts to trap intruders or would - be thieves in a disrupted time flow.",
                Level = 17,
                CanBeDetectedMagically = false,
                TypeId = seeder.GetHazardTypeByName("Traps").Id,
                ComplexityId = seeder.GetComplexityByName("Simple").Id
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents(HazardSeeder seeder)
        {
            yield break;
        }

        protected override IEnumerable<string> GetImmunities()
        {
            yield break;
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Magical";
            yield return "Trap";
        }

        protected override IEnumerable<HazardAction> GetActions(HazardSeeder seeder)
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("21a56455-6731-4be9-bc6b-02130bac5957"),
                Name = "Adrift in Time",
                Traits = seeder.FilterTraits("Occult", "Transmutation"),
                Trigger = "A creature touches the warded object or area",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                EffectDetails =
                {
                    new HazardActionEffectBlock { Id = Guid.Parse("806735c8-382d-4647-a8fd-b33e379cebad"), Text = "The triggering creature and all creatures within 30 feet are trapped in a disrupted time flow (DC 38 Fortitude negates). The creatures’ minds move so quickly that each round seems to last a century, but their bodies and magical energies move so slowly that they can’t use any actions except Recall Knowledge. An affected creature must attempt a DC 36 Will saving throw against a warp mind spell immediately and again for every minute of real time that passes while the creature is trapped in the frozen moment. This effect has an unlimited duration but can be counteracted." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("ac65acb9-87f9-490b-91e8-b80d3943349f"),
                RequiredProficiencyId = seeder.GetProficiencyByName("Master").Id,
                DifficultyCheck = 30
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("f5a17566-7306-40d5-b07f-f7152470593d"),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Legendary").Id,
                Description = "to rapidly disassemble the spell's myriad components in a single blink of an eye",
                DifficultyCheck = 38
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements(HazardSeeder seeder)
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("bb9a1fb9-c343-46e0-a7dc-dcdd239b6107"),
                Level = 8,
                Description = "to counteract the trap before it triggers or to counteract the effect on one creature after the trap is triggered",
                CounteractDifficultyCheck = 36
            };
        }

        protected override SourcePage GetSourcePage(HazardSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9217066-3a54-4767-ae52-5eaf6a8f4f28"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 525
            };
        }
    }
}
