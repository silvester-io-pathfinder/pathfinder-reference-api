using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class VorpalExecutioner : Template
    {
        public static readonly Guid ID = Guid.Parse("3594dc7a-7749-4a92-8b2c-0dbe0ece4ce0");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Vorpal Executioner",
                Description = "A wickedly sharp saw blade descends and travels along grooves in a complex path throughout the room, attempting to decapitate everyone within.",
                Level = 19,
                ArmorClass = 43,
                Fortitude = 32,
                Reflex = 32,
                Reset = "The trap resets over the course of the round and can be triggered again 1 round later.",
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Simple.ID
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("4637940f-d638-4595-96b2-243eb78c0b6f"),
                Name = "Per Junction",
                Hardness = 30,
                HitPoints = 120,
                BrokenThreshold = 60
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
                Id = Guid.Parse("6394bcae-4701-476c-81a6-c154f616ddb5"),
                Name = "Total Decapitation",
                Trigger = "A creature attempts to exit the room",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("23e284eb-40a6-4934-8d0a-88b4a0c0e23c"), Type = TextBlockType.Text, Text = "The saw blade travels along its path, making one Strike against each creature in the room, twisting and varying its height for a maximum chance of beheading its targets." },
                },
                Effects =
                {
                    new AttackHazardActionEffect
                    {
                        Id = Guid.Parse("a1c733d6-f608-4f7a-b8a0-3e7866285f77"),
                        Traits = FilterTraits("Death", "Deadly"),
                        Addendum = "The attack gains an additional d12 damage on critical hits due to its Deadly trait.",
                        AttackTypeId = AttackTypes.Instances.Melee.ID,
                        ActionTypeId = ActionTypes.Instances.NoAction.ID,
                        DamageTypeId = DamageTypes.Instances.Slashing.ID,
                        Damage = "6d12+26",
                        Weapon = "Saw Blade",
                        ProficiencyBonus = 40
                    },
                    new OtherHazardActionEffect
                    {
                        Id = Guid.Parse("f60eac7a-76ae-4793-9298-e1eac798b176"),
                        Effect = "On a critical hit, a target must succeed at a DC 39 Fortitude save or be decapitated, dying instantly unless it can survive without a head"
                    }
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("59d15c2b-1c2b-4f02-a03c-4b52d1dd6572"),
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                DifficultyCheck = 43
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("6c4b294a-6018-43f7-8b64-35bd2710d641"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                Description = "At four different junctions to jam all the saw blade's possible paths, preventing it from traveling through the room.",
                DifficultyCheck = 41
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
                Id = Guid.Parse("ca2171bd-fde9-4caf-9dd4-6f9ddc14ff5e"),
                SourceId = CoreRulebook.ID,
                Page = 525
            };
        }
    }
}
