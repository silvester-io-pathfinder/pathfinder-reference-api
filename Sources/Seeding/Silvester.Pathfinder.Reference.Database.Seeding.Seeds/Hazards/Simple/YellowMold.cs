using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Hazards.Simple
{
    public class YellowMold : Template
    {
        public static readonly Guid ID = Guid.Parse("33cde414-62f3-455d-95a2-f0a63480a006");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Yellow Mold",
                Description = "Poisonous mold spores assault nearby creatures.",
                Level = 8,
                ArmorClass = 27,
                Fortitude = 17,
                Reflex = 13,
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.EnvironmentalHazards.ID,
                ComplexityId = HazardComplexities.Instances.Simple.ID
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("bf392e6d-9811-4263-9e96-d21ccfeb3bf4"),
                Name = "Mold",
                HitPoints = 70,
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
            yield return Traits.Instances.Environmental.ID;
            yield return Traits.Instances.Fungus.ID;
        }

        protected override void GetActions(InlineActionCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("dd06ccd9-ca0a-4797-b135-590a5509eb32"), ActionTypes.Instances.Reaction.ID, "Spore Exploison", action =>
            {
                action
                    .Trigger("A creature moves into the mold's space or damages the mold. The mold can't use this reaction if it's in direct sunlight or if the damage was fire damage.")
                    .Details(details =>
                    {
                        details.Text(Guid.Parse("416e47cd-3a39-4e6b-93ba-d7560655d2aa"), "The triggering creature and all creatures within 10 feet are exposed to yellow mold spores.");
                    })
                    .StaggeredEffect(Guid.Parse("71481eb7-bd47-4804-9de0-2225a6414d48"), "Yellow Mold Spores", "Immediate.", SavingThrowStats.Instances.Fortitude.ID, "6 rounds.", effect => 
                    {
                        effect
                            .DifficultyCheck(26)
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("9e2c8d15-90ce-42b5-85a7-0f368fb7a7e7"), Traits.Instances.Inhaled.ID);
                                traits.Add(Guid.Parse("568f6b38-f30d-4f0f-ab3f-077f786c7a31"), Traits.Instances.Poison.ID);
                            })
                            .Addendum("Any drained condition from the spores persist after the poison's duration ends.")
                            .Stage(Guid.Parse("5da9acfe-5458-4f7a-bfab-6826cf9d5c3c"), "1 Round.", stage =>
                            {
                                stage.Effect(new DamageEffect { Id = Guid.Parse("451e7a2f-0cea-4e95-b3a2-570fdbd2b452"), Damage = "1d8", DamageTypeId = DamageTypes.Instances.Poison.ID });
                                stage.Effect(new ConditionEffect { Id = Guid.Parse("5f0eaf21-7e87-400a-9e5c-76ac71e25323"), ConditionId = Drained.ID, Severity = 1 });
                            })
                            .Stage(Guid.Parse("f85e5ada-f326-4062-bc07-b6bf70bcb890"), "1 Round.", stage =>
                            {
                                stage.Effect(new DamageEffect { Id = Guid.Parse("3ea75142-a736-483f-b353-110621dae868"), Damage = "2d8", DamageTypeId = DamageTypes.Instances.Poison.ID });
                                stage.Effect(new ConditionEffect { Id = Guid.Parse("20779b36-4f8e-4e0f-908f-1c8763dd0381"), ConditionId = Drained.ID, Severity = 2 });
                            })
                            .Stage(Guid.Parse("2670560e-815c-429a-b6ff-aa7fd95d0fa8"), "1 Round.", stage =>
                            {
                                stage.Effect(new DamageEffect { Id = Guid.Parse("20e13453-ee1d-462b-b088-0fce0b39d925"), Damage = "3d8", DamageTypeId = DamageTypes.Instances.Poison.ID });
                                stage.Effect(new ConditionEffect { Id = Guid.Parse("ffb723ae-f741-4d89-bae2-50b62fdf5405"), ConditionId = Drained.ID, Severity = 3 });
                            });
                    });
            });
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("5156bfe8-1e25-4b24-b749-14a00c1d5b65"),
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                DifficultyCheck = 28
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("b7eff338-cc48-4aa8-9e7f-630e3b10d70e"),
                SkillId = Skills.Instances.Survival.ID,
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                Description = "To remove the mold without triggering the spores.",
                DifficultyCheck = 26
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
                Id = Guid.Parse("7fb587a3-cfa2-4098-8416-8e2eb615b325"),
                SourceId = CoreRulebook.ID,
                Page = 524
            };
        }
    }
}
