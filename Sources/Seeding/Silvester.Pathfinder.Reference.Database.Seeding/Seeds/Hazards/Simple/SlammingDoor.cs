using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Hazards.Simple
{
    public class SlammingDoor : Template
    {
        public static readonly Guid ID = Guid.Parse("504d33ef-0441-4972-b5f5-7019b895e2c6");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Slamming Door",
                Description = "Pressure-sensitive panels in the floor connect to a stone slab hidden in a hallway's ceiling.",
                Level = 1,
                ArmorClass = 16,
                Fortitude = 10,
                Reflex = 2,
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Simple.ID
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("64216b89-2ab1-4f40-8f77-5eb6d33d14cb"),
                Name = "Pressure Plate",
                HitPoints = 20,
                Hardness = 5,
                BrokenThreshold = 10,
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
                Id = Guid.Parse("57f67171-9fe7-42a8-9338-9dfcff0c17b1"),
                Name = "Slam Shut",
                Trigger = "Pressure is placed on any floor tile.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("67f6c155-f410-4fdb-bfdf-ea6988d88003"), Type = TextBlockType.Text, Text = "The door falls, closing off the hallway. The stone slab deals 3d8 bludgeoning damage to anyone beneath or adjacent to the slab when it drops and pushes them out of its space in a random direction. A creature that succeeds at a DC 17 Reflex save takes no damage and rolls out of the way in a random direction. On a critical success, they can choose the direction." },
                    new TextBlock { Id = Guid.Parse("85896c21-0853-44e8-90ea-b304cdbb0f14"), Type = TextBlockType.Text, Text = "Lifting the fallen slab requires a successful DC 25 Athletics check. Hitting the floor panels triggers the trap. The slab uses the same AC and saves as the trap, but it has Hardness 12, HP 48 (BT 24)." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("1ef8b7a1-e790-4129-81e8-6b172be66f48"),
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                DifficultyCheck = 17
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("489b3fef-ff29-4e09-8436-7905dba58c27"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                Description = "On the floor panels before the slab falls.",
                DifficultyCheck = 15
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
                Id = Guid.Parse("86cca78f-c85b-4691-b633-93f649675e00"),
                SourceId = CoreRulebook.ID,
                Page = 523
            };
        }
    }
}
