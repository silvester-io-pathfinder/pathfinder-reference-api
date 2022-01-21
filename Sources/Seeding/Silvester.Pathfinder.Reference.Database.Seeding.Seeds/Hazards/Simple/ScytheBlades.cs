using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineAttacks;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Hazards.Simple
{
    public class ScytheBlades : Template
    {
        public static readonly Guid ID = Guid.Parse("b658c798-2ef4-4040-9980-7828bbeeb523");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Scythe Blades",
                Description = "Two blades, each hidden in a 15-foot-long ceiling groove, are both connected to a trip wire.",
                Level = 4,
                ArmorClass = 21,
                Fortitude = 12,
                Reflex = 8,
                Reset = "The trap resets after 15 minutes.",
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Simple.ID
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("f86b81de-3078-4de8-9ad0-ab30250b4df5"),
                Name = "Blades",
                HitPoints = 44,
                Hardness = 11,
                BrokenThreshold = 22,
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
            builder.Add(Guid.Parse("574be793-dfaa-4b21-ac86-4c65fd08bd92"), ActionTypes.Instances.Reaction.ID, "Falling Scythes", action =>
            {
                action
                    .Trigger("The trip wire is pulled or severed.")
                    .Details(details =>
                    {
                        details.Text(Guid.Parse("99511947-964d-4238-bba3-e8f5c44be0b4"), "Both blades swing down, each one Striking all creatures under the ceiling grooves.");
                    });
            });
        }

        protected override void GetAttacks(InlineAttackCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("cf6f60f5-8d68-45af-8f92-2183ae264e13"), AttackTypes.Instances.Melee.ID, ActionTypes.Instances.NoAction.ID, "Scythe", hitModifier: 17, "2d12+4", DamageTypes.Instances.Slashing.ID, attack =>
            {
                attack
                    .Traits(traits =>
                    {
                        traits.Add(Guid.Parse("0b8d1fa8-871e-4801-adb9-dd9e4c3a7792"), Traits.Instances.Deadly.ID, "1d12");
                    })
                    .Details(details => 
                    {
                        details.Text(Guid.Parse("65b7b591-7471-492a-8fab-454c9065f0cb"), "The attack suffers no multiple attack penalty.");
                    });
            });
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("896ea8f0-24b3-4532-81a3-b7a8f1edcbcd"),
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                DifficultyCheck = 23
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("859314b5-6c92-43b6-964b-fad36bd66f0f"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                Description = "To disable each blade.",
                DifficultyCheck = 21
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
                Id = Guid.Parse("719ab320-45f1-4057-aaea-11055889b36a"),
                SourceId = CoreRulebook.ID,
                Page = 523
            };
        }
    }
}
