using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Complex
{
    public class TelekineticSwarmTrap : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("12cbc8b1-311a-4826-bf59-784c2a790e0f");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Telekinetic Swarm Trap",
                Description = "Three innocuous decorations instilled with telekinetic magic pull objects and pieces of the room itself into spinning clouds of debris that attack all creatures in the room.",
                Level = 12,
                ArmorClass = 33,
                Fortitude = 24,
                Reflex = 19,
                Reset = "The trap deactivates and resets 10 minutes after it has no target creatures (because the creatures either moved too far away or died).",
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Complex.ID,
                RoutineActions = 9
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("30fc20e8-9dfe-445d-baa4-741113fa20a7"),
                Name = "Trap",
                Hardness = 22,
                HitPoints = 88,
                BrokenThreshold = 44,
            };
        }

        protected override IEnumerable<Guid> GetImmunities()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Complex.ID;
            yield return Traits.Instances.Mechanical.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Trap.ID;
        }

        protected override IEnumerable<TextBlock> GetRoutineDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5bfc3074-35e2-4406-bcd4-152b4c8f3069"), Type = TextBlockType.Text, Text = "Each decoration uses 3 of the trap’s actions each turn, and the trap loses 3 actions each turn for every decoration that is disabled. A decoration uses its first action to move its cloud of objects up to 200 feet, its second action to make the objects Strike, and its third action to add more objects to the cloud, increasing its damage by 1d12 (to a maximum of 4d12+10). If a decoration’s cloud is already at maximum damage, it does nothing with its third action." };
            yield return new TextBlock { Id = Guid.Parse("3564caf0-6c49-4cff-9e37-0cfdc2f57bf2"), Type = TextBlockType.Text, Text = "If a decoration’s cloud has been destroyed, the decoration instead spends its first action to create a new cloud of objects inside the room (using the starting damage value) and then its second and third actions to have the cloud move and Strike." };
        }

        protected override IEnumerable<HazardAction> GetActions()
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("5ea54988-b386-4036-a0fc-914995d621de"),
                Name = "Agitate",
                Traits = FilterTraits("Arcane", "Evocation"),
                Trigger = "A creature stays in the room for at least 6 seconds; ",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Details =
                {
                    new TextBlock { Id = Guid.Parse("76ef593c-5381-4d39-8935-56aad69cdecf"), Type = Utilities.Text.TextBlockType.Text, Text = "Each telekinetic decoration constructs a cloud of objects in the room (three clouds total) and the trap rolls initiative. The creatures in the room when the trap is triggered become the trap’s targets, regardless of whether they leave the room or other creatures later enter the room. Each decoration targets a different creature if possible. A target creature that moves at least 1 mile from the trap ceases being a target, at which point the decoration designates a new target." },
                },
                Effects = new HazardActionEffect[]
                {
                    new AttackHazardActionEffect
                    {
                        Id = Guid.Parse("3a9d125a-3dc2-41a2-80bb-079119e46900"),
                        AttackTypeId = AttackTypes.Instances.Melee.ID,
                        ActionTypeId = ActionTypes.Instances.OneAction.ID,
                        DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
                        Damage = "2d12+10",
                        Weapon = "Objects",
                        ProficiencyBonus = 24
                    },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("427e2693-7176-4c7d-97ab-2c13f5f31ab5"),
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                DifficultyCheck = 24
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("e67d33a3-07a3-4d57-bc2b-3dc160604364"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                Description = "to take apart a telekinetic cloud",
                DifficultyCheck = 27
            };

            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("a95ccc7b-c497-4240-890c-6205554bc7f2"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Master.ID,
                Description = "to disable each telekinetic decoration",
                DifficultyCheck = 32
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements()
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("efd5de03-fb71-4e23-b059-6d113d24d3cb"),
                Level = 6,
                Description = "to counteract each telekinetic decoration",
                CounteractDifficultyCheck = 30
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("766886e3-4c2d-407c-9691-d36cb4a21258"),
                SourceId = CoreRulebook.ID,
                Page = 528
            };
        }
    }
}
