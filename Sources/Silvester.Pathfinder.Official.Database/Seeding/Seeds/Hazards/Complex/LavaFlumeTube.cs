using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Complex
{
    public class LavaFlumeTube : Template
    {
        public static readonly Guid ID = Guid.Parse("3a554a92-f873-4560-9a1a-ad10916b7f1a");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Lava Flume Tube",
                Description = "Four gated channels carved into stone allow lava to flow into a 15-foot-tall room; the floor can withdraw to allow the hardened lava to fall into a chamber beneath.",
                Level = 10,
                ArmorClass = 30,
                Fortitude = 20,
                Reflex = 16,
                Reset = "The trap deactivates and resets after 1 hour by withdrawing the floor, cracking and dumping the hardened lava (and any creatures trapped inside) into the chamber. Creatures fall 40 feet, taking falling damage (typically 17 bludgeoning damage).",
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Complex.ID,
                RoutineActions = 4
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("02718d69-a47d-46e1-bc52-00504d473fe7"),
                Name = "Channel",
                Hardness = 12,
                HitPoints = 48,
                BrokenThreshold = 24,
            };

            yield return new HazardComponent
            {
                Id = Guid.Parse("792ae459-b52a-40da-b131-49c9a459c732"),
                Name = "Floor",
                Hardness = 18,
                HitPoints = 72,
                BrokenThreshold = 36,
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
            yield return Traits.Instances.Complex.ID;
            yield return Traits.Instances.Mechanical.ID;
            yield return Traits.Instances.Trap.ID;
        }

        protected override IEnumerable<TextBlock> GetRoutineDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("dbc0d3e9-fac4-47d3-8942-09f87c55df5d"), Type = TextBlockType.Text, Text = "The trap loses 1 action per disabled channel each turn. On each action, a different channel spews lava, dealing 4d6 fire damage to each creature within 10 feet of the channel (DC 27 basic Reflex save), and increasing the depth of the lava in the room by 1 foot (4 feet per round if all the channels are active)." };
            yield return new TextBlock { Id = Guid.Parse("58d97828-a01d-4101-b04e-d5e3b804b7a8"), Type = TextBlockType.Text, Text = "A creature that starts its turn in lava takes 8d6 fire damage and is immobilized until it Escapes the hardening lava (DC 27). The creature might suffocate if covered in lava (page 478). Lava from the previous round hardens fully at the start of the trap’s turn, effectively raising the floor of the room. Once the room is full of lava, the trap stops taking actions, but creatures in the room remain stuck until the floor opens and the trap resets." };
        }

        protected override IEnumerable<HazardAction> GetActions()
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("d42112ae-d850-451a-ac03-2aba67ec4a75"),
                Name = "Flume Activation",
                Trigger = "A creature tries to leave the room",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Details =
                {
                    new TextBlock { Id = Guid.Parse("1b710bb7-2c56-42fd-a03d-2b2861a8b23f"), Type = Utilities.Text.TextBlockType.Text,  Text = "The exits seal instantly and the trap rolls initiative." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("73847cf1-da7f-4f4e-9e4f-d7eb4551e688"),
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                DifficultyCheck = 19
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("35b9fe03-9f51-45a9-9e76-32553c8e831f"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                Description = "to block a channel",
                DifficultyCheck = 29
            };

            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("90759a5b-4504-4109-89eb-00f2d4afeb20"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Master.ID,
                Description = "to to release the floor latch and escape to the chamber below",
                DifficultyCheck = 31
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
                Id = Guid.Parse("9c7423cd-e07c-4a28-8d25-3b3cc4578690"),
                SourceId = CoreRulebook.ID,
                Page = 528
            };
        }
    }
}
