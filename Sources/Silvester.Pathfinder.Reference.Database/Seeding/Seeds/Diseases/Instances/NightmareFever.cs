using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Diseases.Instances
{
    public class NightmareFever : Template
    {
        public static readonly Guid ID = Guid.Parse("944b86e1-373a-4bb8-bf00-2c8a2664cdd2");

        public override Disease GetDisease()
        {
            return new Disease
            {
                Id = ID,
                Name = "Nightmare Fever",
                Description = "Thought to be caused by a night hag’s curse, nightmare fever inflicts you with terrible nightmares, and you awaken with the wounds you received in your dreams. Some versions cause you to dream of being wounded by bludgeoning or piercing weapons, in which case you take that type of damage instead. Damage and the fatigued condition caused by the disease can’t be healed until the disease is removed.",
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                DifficultyCheck = 25,
                Onset = "Immediate"
            };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cc5aec5c-f514-4626-bfe3-e62fcd7c8e3a"),
                SourceId = GamemasteryGuide.ID,
                Page = 119
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Disease.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Occult.ID;
        }

        public override IEnumerable<DiseaseStage> GetDiseaseStages()
        {
            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Fatigued.ID},
                    new DamageDiseaseStageEffect {DamageTypeId = DamageTypes.Instances.Slashing.ID, Damage = "2d6"}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Fatigued.ID},
                    new DamageDiseaseStageEffect {DamageTypeId = DamageTypes.Instances.Slashing.ID, Damage = "4d6"}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Fatigued.ID},
                    new DamageDiseaseStageEffect {DamageTypeId = DamageTypes.Instances.Slashing.ID, Damage = "4d6"},
                    new OtherDiseaseStageEffect { Effect = "Whenever you take slashing damage, you must succeed at a Will save against the disease’s DC or become frightened 2."}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Fatigued.ID},
                    new DamageDiseaseStageEffect {DamageTypeId = DamageTypes.Instances.Slashing.ID, Damage = "6d6"},
                    new OtherDiseaseStageEffect { Effect = "Whenever you take slashing damage, you must succeed at a Will save against the disease’s DC or become paralyzed for 1 round."}
                }
            };

            yield return new DiseaseStage
            {
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Unconscious.ID},
                    new DamageDiseaseStageEffect {DamageTypeId = DamageTypes.Instances.Slashing.ID, Damage = "6d6"}
                }
            };
        }
    }
}
