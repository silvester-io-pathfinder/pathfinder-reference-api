using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases.Instances
{
    public class ScarletFever : AbstractDiseaseTemplate
    {
        public static readonly Guid ID = Guid.Parse("f8e30bb2-a932-44b8-bc10-d958d2094645");

        public override Disease GetDisease(DiseaseSeeder seeder)
        {
            return new Disease
            {
                Id = ID,
                Name = "Scarlet Fever",
                Description = "he relatively simple sore throat caused by this disease leads many victims to initially dismiss it as a mild illness, but scarlet fever can be deadly if left untreated. You can’t reduce your sickened condition while affected with scarlet fever.",
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                DifficultyCheck = 13,
                Onset = "2 Days"
            };
        }

        public override SourcePage? GetSourcePage(DiseaseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("664e842a-4b94-4d00-836d-4191c3b5df50"),
                SourceId = seeder.GetSourceByName("Gamemastery Guide").Id,
                Page = 118
            };
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Disease";
        }

        public override IEnumerable<DiseaseStage> GetDiseaseStages(DiseaseSeeder seeder)
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
