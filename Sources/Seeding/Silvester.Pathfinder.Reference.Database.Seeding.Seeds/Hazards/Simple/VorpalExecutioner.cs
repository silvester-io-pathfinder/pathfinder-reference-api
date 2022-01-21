using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineAttacks;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Hazards.Simple
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

        protected override void GetActions(InlineActionCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("6394bcae-4701-476c-81a6-c154f616ddb5"), ActionTypes.Instances.Reaction.ID, "", action =>
            {
                action
                    .Trigger("A creature attempts to exit the room.")
                    .Details(details =>
                    {
                        details.Text(Guid.Parse("23e284eb-40a6-4934-8d0a-88b4a0c0e23c"), "The saw blade travels along its path, making one Strike against each creature in the room, twisting and varying its height for a maximum chance of beheading its targets.");
                    });
            });
        }

        protected override void GetAttacks(InlineAttackCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("a1c733d6-f608-4f7a-b8a0-3e7866285f77"), AttackTypes.Instances.Melee.ID, ActionTypes.Instances.NoAction.ID, "Saw Blade", hitModifier: 40, "6d12+25", DamageTypes.Instances.Slashing.ID, attack => 
            {
                attack
                    .Traits(traits => 
                    {
                        traits.Add(Guid.Parse("ec9b990f-5387-43da-b494-c29c4334f6a0"), Traits.Instances.Deadly.ID, "d12");
                        traits.Add(Guid.Parse("27ef5e5b-8ba0-4741-ab5a-dc95c556bc12"), Traits.Instances.Death.ID);
                    })
                    .Details(details =>
                    {
                        details.Text(Guid.Parse("abaf0284-3f65-4a08-a755-2dacaa1cdc40"), "Does not suffer from multiple attack penalty.");
                        details.Heading(Guid.Parse("463edece-b55e-47ac-beaa-f1931b406d69"), "Decapitation");
                        details.Text(Guid.Parse("f60eac7a-76ae-4793-9298-e1eac798b176"), "On a critical hit, a target must succeed at a DC 39 Fortitude save or be decapitated, dying instantly unless it can survive without a head.");
                    });
            });
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
