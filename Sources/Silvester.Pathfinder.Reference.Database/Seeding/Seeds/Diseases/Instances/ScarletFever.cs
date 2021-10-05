using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Diseases.Instances
{
    public class ScarletFever : Template
    {
        public static readonly Guid ID = Guid.Parse("f8e30bb2-a932-44b8-bc10-d958d2094645");

        public override Disease GetDisease()
        {
            return new Disease
            {
                Id = ID,
                Name = "Scarlet Fever",
                Description = "he relatively simple sore throat caused by this disease leads many victims to initially dismiss it as a mild illness, but scarlet fever can be deadly if left untreated. You can’t reduce your sickened condition while affected with scarlet fever.",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DifficultyCheck = 13,
                Onset = "2 Days"
            };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("664e842a-4b94-4d00-836d-4191c3b5df50"),
                SourceId = GamemasteryGuide.ID,
                Page = 118
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Disease.ID;
        }

        public override IEnumerable<DiseaseStage> GetDiseaseStages()
        {
            yield return new DiseaseStage 
            { 
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[] 
                {
                    new ConditionDiseaseStageEffect { ConditionId = Sickened.ID, Severity = 1}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Sickened.ID, Severity = 2}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Sickened.ID, Severity = 3},
                    new ConditionDiseaseStageEffect { ConditionId = Muted.ID}
                }
            };

            yield return new DiseaseStage
            {
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Dead.ID},
                }
            };
        }
    }
}
