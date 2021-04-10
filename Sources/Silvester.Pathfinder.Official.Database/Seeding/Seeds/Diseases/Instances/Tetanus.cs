using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases.Instances
{
    public class Tetanus : AbstractDiseaseTemplate
    {
        public static readonly Guid ID = Guid.Parse("ca8a8c1e-0426-48a4-81f3-38fbc309d348");

        public override Disease GetDisease(DiseaseSeeder seeder)
        {
            return new Disease
            {
                Id = ID,
                Name = "Tetanus",
                Description = "An infection introduced through open wounds, tetanus can produce stiffness, muscle spasms strong enough to break bones, and ultimately death.",
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                DifficultyCheck = 14,
                Onset = "10 Days"
            };
        }

        public override SourcePage? GetSourcePage(DiseaseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ae81453-5952-413b-a8eb-0baab2ae85d9"),
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
                Duration = TimeSpan.FromDays(7),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Clumsy.ID, Severity = 1}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Clumsy.ID, Severity = 2},
                    new ConditionDiseaseStageEffect { ConditionId = Muted.ID}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Paralyzed.ID},
                    new ConditionDiseaseStageEffect { ConditionId = Spasming.ID}
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
