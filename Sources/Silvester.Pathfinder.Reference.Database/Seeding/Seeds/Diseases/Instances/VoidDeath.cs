using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Diseases.Instances
{
    public class VoidDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("a126527c-f9d1-498f-9d53-ee01009a80e5");

        public override Disease GetDisease()
        {
            return new Disease
            {
                Id = ID,
                Name = "Void Death",
                Description = "An akata implants its parasitic larval young into any creature it bites, but only Medium or Small humanoids make suitable hosts; all other creatures are immune to this disease",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DifficultyCheck = 17,
                Onset = "1 Day"
            };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5108e12f-9672-4072-a697-d7602a132ccc"),
                SourceId = Bestiary2.ID,
                Page = 13
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        public override IEnumerable<DiseaseStage> GetDiseaseStages()
        {
            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Carrier.ID}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 1}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 1}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 2},
                    new ConditionDiseaseStageEffect { ConditionId = Fatigued.ID}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 2},
                    new ConditionDiseaseStageEffect { ConditionId = Fatigued.ID}
                }
            };

            yield return new DiseaseStage
            {
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Dead.ID},
                    new OtherDiseaseStageEffect { Effect = "The corpse rises as a void zombie (page 288) in 2d4 hours."}
                }
            };
        }
    }
}
