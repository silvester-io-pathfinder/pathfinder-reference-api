using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class ElectricLatchRune : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("53829d01-6277-47bd-9b7c-9f002c965664");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Electric Latch Rune",
                Description = "An invisible rune imprinted on a door latch releases a powerful electric discharge.",
                Level = 3,
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
            yield return Traits.Instances.Electricity.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Trap.ID;
        }

        protected override IEnumerable<HazardAction> GetActions()
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("a1bbebc2-a500-44f9-8142-b77421a53107"),
                Name = "Electrocution",
                Trigger = "A creature grasps the door latch directly or with a tool",
                Traits = FilterTraits("Arcane", "Electricity", "Evocation"),
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
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
                        DamageTypeId = DamageTypes.Instances.Electricity.ID,
                        SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID
                    }
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("05218d9d-3f83-40cb-accc-6436829112ae"),
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                DifficultyCheck = 20
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("fc01265c-7160-4b5c-adf8-f6d59d95ff10"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                Description = "to scratch out the rune without allowing electricity to flow",
                DifficultyCheck = 20
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements()
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("87bd008f-469d-4e23-95ac-517dc3070bf7"),
                Level = 2,
                Description = "to counteract the rune",
                CounteractDifficultyCheck = 18
            };
        }

        protected override SourcePage GetSourcePage()
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
