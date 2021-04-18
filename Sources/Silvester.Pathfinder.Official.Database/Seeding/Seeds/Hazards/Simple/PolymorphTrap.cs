using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class PolymorphTrap : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("0b60cd6f-d1e8-4373-83f8-a14907af7e10");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Polymorph Trap",
                Description = "A Druidic glyph tries to transform a trespasser into an animal.",
                Level = 12,
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
                Id = Guid.Parse("0b60cd6f-d1e8-4373-83f8-a14907af7e10"),
                Name = "Baleful Polymorph",
                Traits = seeder.FilterTraits("Primal", "Transmutation"),
                Trigger = "A creature moves within 30 feet of the glyph without speaking the passphrase in Druidic;",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("50fc5c54-2b32-41dc-960f-7aee5dc71077"), Type = TextBlockType.Text, Text = "The creature is targeted by baleful polymorph (DC 32 Will save)." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("9aed056b-3e12-40eb-bf1c-46a2c221ecb9"),
                RequiredProficiencyId = seeder.GetProficiencyByName("Trained").Id,
                DifficultyCheck = 34
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("8874b07f-fdaf-496e-8090-8e89c9993781"),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Master").Id,
                Description = "to drain the glyph's power harmlessly",
                DifficultyCheck = 32
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements(HazardSeeder seeder)
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("52927b96-561a-43ea-a992-481218889a7c"),
                Level = 6,
                Description = "to counteract the glyph",
                CounteractDifficultyCheck = 30
            };
        }

        protected override SourcePage GetSourcePage(HazardSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae8ab02b-c174-4d9f-8d93-278c34756eea"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 525
            };
        }
    }
}
