using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class ElectricLatchRune : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("53829d01-6277-47bd-9b7c-9f002c965664");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Electric Latch Rune",
                Description = "An invisible rune imprinted on a door latch releases a powerful electric discharge.",
                Level = 3,
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
            yield return "Electricity";
            yield return "Evocation";
            yield return "Magical";
            yield return "Trap";
        }

        protected override IEnumerable<HazardAction> GetActions(HazardSeeder seeder)
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("a1bbebc2-a500-44f9-8142-b77421a53107"),
                Name = "Electrocution",
                Trigger = "A creature grasps the door latch directly or with a tool",
                Traits = seeder.FilterTraits("Arcane", "Electricity", "Evocation"),
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("d1e49618-1459-444d-b843-e65168e0ea3f"), Type = TextBlockType.Text, Text = "The trap deals 3d12 electricity damage to the triggering creature (DC 22 basic Reflex save)." },
                },
                Effects =
                {
                    new SpellHazardActionEffect
                    {
                        Id = Guid.Parse("d08408da-a6f3-4720-8e9c-dc19dea63041"),
                        Damage = "3d12",
                        DifficultyCheck = 22,
                        DamageTypeId = seeder.GetDamageTypeByName("Electricity").Id,
                        SavingThrowStatId = seeder.GetSavingThrowStatByName("Reflex").Id
                    }
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("05218d9d-3f83-40cb-accc-6436829112ae"),
                RequiredProficiencyId = seeder.GetProficiencyByName("Trained").Id,
                DifficultyCheck = 20
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("fc01265c-7160-4b5c-adf8-f6d59d95ff10"),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Expert").Id,
                Description = "to scratch out the rune without allowing electricity to flow",
                DifficultyCheck = 20
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements(HazardSeeder seeder)
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("87bd008f-469d-4e23-95ac-517dc3070bf7"),
                Level = 2,
                Description = "to counteract the rune",
                CounteractDifficultyCheck = 18
            };
        }

        protected override SourcePage GetSourcePage(HazardSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("a83b813a-4c84-482b-b232-30afec68d03b"),
                SourceId = CoreRulebook.ID,
                Page = 523
            };
        }
    }
}
