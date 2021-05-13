using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases.Instances
{
    public class SewerHaze : Template
    {
        public static readonly Guid ID = Guid.Parse("9e6fec9d-0ab3-450e-a0fa-a074ca4b4b6c");

        public override Disease GetDisease()
        {
            return new Disease
            {
                Id = ID,
                Name = "Sewer Haze",
                Description = "Many healers and alchemists suspect that sewer haze has a supernatural origin, given its association with particularly strong otyughs.",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DifficultyCheck = 23,
                Onset = "2 Days"
            };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f757d30-7c60-4217-a742-613ae6bb3830"),
                SourceId = GamemasteryGuide.ID,
                Page = 119
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Disease.ID;
            yield return Traits.Instances.Virulent.ID;
        }

        public override IEnumerable<DiseaseStage> GetDiseaseStages()
        {
            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Stupefied.ID, Severity = 2}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Stupefied.ID, Severity = 2},
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 2}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Stupefied.ID, Severity = 3},
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 3}
                }
            };
        }
    }
}
