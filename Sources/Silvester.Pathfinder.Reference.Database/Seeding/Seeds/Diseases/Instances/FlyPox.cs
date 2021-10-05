using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Diseases.Instances
{
    public class FlyPox : Template
    {
        public static readonly Guid ID = Guid.Parse("13952f0f-9ded-47eb-880c-415028b67700");

        public override Disease GetDisease()
        {
            return new Disease
            {
                Id = ID,
                Name = "Fly Pox",
                Description = "A giant fly could carry any disease, but most transmit a virulent but not fatal infection called Fly Pox with their bite",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DifficultyCheck = 16,
                Onset = "1 Day"

            };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13952f0f-9ded-47eb-880c-415028b67700"),
                SourceId = GamemasteryGuide.ID,
                Page = 120
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
                    new ConditionDiseaseStageEffect { ConditionId = Enfeebled.ID, Severity = 1}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Enfeebled.ID, Severity = 1}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Enfeebled.ID, Severity = 2}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Enfeebled.ID, Severity = 2}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Enfeebled.ID, Severity = 2},
                    new ConditionDiseaseStageEffect { ConditionId = Fatigued.ID}
                }
            };
        }
    }
}
