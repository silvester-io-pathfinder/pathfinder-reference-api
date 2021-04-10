using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases.Instances
{
    public class Bonechill : AbstractDiseaseTemplate
    {
        public static readonly Guid ID = Guid.Parse("0420dbd7-79bc-420d-b926-6f1d66f6d14e");

        public override Disease GetDisease(DiseaseSeeder seeder)
        {
            return new Disease
            {
                Id = ID,
                Name = "Bonechill",
                Description = "If you are wounded and exposed to persistent cold, you might contract bonechill.",
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                DifficultyCheck = 20,
                Onset = "1 Day"
            };
        }

        public override SourcePage? GetSourcePage(DiseaseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e838c4f-13ff-4587-a840-f4bc36a01360"),
                SourceId = seeder.GetSourceByName("Gamemastery Guide").Id,
                Page = 118
            };
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Disease";
            yield return "Necromancy";
            yield return "Primal";
        }

        public override IEnumerable<DiseaseStage> GetDiseaseStages(DiseaseSeeder seeder)
        {
            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
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
                    new OtherDiseaseStageEffect { Effect = "You cannot heal cold damage until the disease is cured."}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Clumsy.ID, Severity = 3},
                    new OtherDiseaseStageEffect { Effect = "You cannot heal cold damage until the disease is cured."},
                    new OtherDiseaseStageEffect { Effect = "All cold temperature effects are one step more severe for the victim."}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Paralyzed.ID},
                    new OtherDiseaseStageEffect { Effect = "You cannot heal cold damage until the disease is cured."},
                    new OtherDiseaseStageEffect { Effect = "All cold temperature effects are one step more severe for the victim."}
                }
            };
        }
    }
}
