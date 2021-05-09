using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class SpearLauncher : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("9acfc457-78d5-4af1-a8b1-a09f9f2d8312");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Spear Launcher",
                Description = "A wall socket loaded with a spear connects to a floor tile in one 5-foot square.",
                Level = 2,
                ArmorClass = 18,
                Fortitude = 11,
                Reflex = 3,
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Simple.ID
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("1b7f63e1-843d-42c6-b2a4-76372dd89691"),
                Name = "Pressure Plate",
                HitPoints = 32,
                Hardness = 8,
                BrokenThreshold = 16,
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
                Id = Guid.Parse("09e804f4-5f1b-4255-b1d1-31e90811b52a"),
                Name = "Spear",
                Trigger = "Pressure is applied to the floor tile",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("fd11a9dd-3a82-4d6f-9861-62c108f617a5"),Type = TextBlockType.Text,  Text = "The trap shoots a spear, making a Strike against the creature or object on the floor tile." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("d1d73ba4-1649-4e87-a432-7d469bea997c"),
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                DifficultyCheck = 20
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("14f6268a-0806-45c2-8150-5967912b2e24"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                Description = "On the floor tile or wall socket.",
                DifficultyCheck = 18
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
                Id = Guid.Parse("ca5b006a-8d72-4b2f-827b-09a48cd3b690"),
                SourceId = CoreRulebook.ID,
                Page = 523
            };
        }
    }
}
