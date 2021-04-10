using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases.Instances
{
    public class SewerHaze : AbstractDiseaseTemplate
    {
        public static readonly Guid ID = Guid.Parse("9e6fec9d-0ab3-450e-a0fa-a074ca4b4b6c");

        public override Disease GetDisease(DiseaseSeeder seeder)
        {
            return new Disease
            {
                Id = ID,
                Name = "Sewer Haze",
                Description = "Many healers and alchemists suspect that sewer haze has a supernatural origin, given its association with particularly strong otyughs.",
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                DifficultyCheck = 23,
                Onset = "2 Days"
            };
        }

        public override SourcePage? GetSourcePage(DiseaseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f757d30-7c60-4217-a742-613ae6bb3830"),
                SourceId = seeder.GetSourceByName("Gamemastery Guide").Id,
                Page = 119
            };
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Disease";
            yield return "Virulent";
        }

        public override IEnumerable<DiseaseStage> GetDiseaseStages(DiseaseSeeder seeder)
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
