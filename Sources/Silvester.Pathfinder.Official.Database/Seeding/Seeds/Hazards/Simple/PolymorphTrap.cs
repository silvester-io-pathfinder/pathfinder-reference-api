using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class PolymorphTrap : Template
    {
        public static readonly Guid ID = Guid.Parse("0b60cd6f-d1e8-4373-83f8-a14907af7e10");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Polymorph Trap",
                Description = "A Druidic glyph tries to transform a trespasser into an animal.",
                Level = 12,
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
                Id = Guid.Parse("0b60cd6f-d1e8-4373-83f8-a14907af7e10"),
                Name = "Baleful Polymorph",
                Traits = FilterTraits("Primal", "Transmutation"),
                Trigger = "A creature moves within 30 feet of the glyph without speaking the passphrase in Druidic;",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("50fc5c54-2b32-41dc-960f-7aee5dc71077"), Type = TextBlockType.Text, Text = "The creature is targeted by baleful polymorph (DC 32 Will save)." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("9aed056b-3e12-40eb-bf1c-46a2c221ecb9"),
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                DifficultyCheck = 34
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("8874b07f-fdaf-496e-8090-8e89c9993781"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Master.ID,
                Description = "To drain the glyph's power harmlessly.",
                DifficultyCheck = 32
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements()
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("52927b96-561a-43ea-a992-481218889a7c"),
                Level = 6,
                Description = "To counteract the glyph.",
                CounteractDifficultyCheck = 30
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae8ab02b-c174-4d9f-8d93-278c34756eea"),
                SourceId = CoreRulebook.ID,
                Page = 525
            };
        }
    }
}
