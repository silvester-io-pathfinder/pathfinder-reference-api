using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases.Instances
{
    public class BogRot : AbstractDiseaseTemplate
    {
        public static readonly Guid ID = Guid.Parse("bdc9c07d-a3bf-4dc1-9ff1-657d2e956e17");

        public override Disease GetDisease(DiseaseSeeder seeder)
        {
            return new Disease
            {
                Id = ID,
                Name = "Bog Rot",
                Description = "Sometimes called bog foot, bog rot is caused by having waterlogged feet for an extended period of time. In addition to the usual cures for an affliction, bog rot can be cured through amputation of the affected appendages.",
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                DifficultyCheck = 13,
                Onset = "1 Day"
            };
        }

        public override SourcePage? GetSourcePage(DiseaseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("11ad942d-bb19-460c-a802-2db23239e202"),
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
                    new ConditionDiseaseStageEffect { ConditionId = Clumsy.ID, Severity = 1}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Clumsy.ID, Severity = 1},
                    new ConditionDiseaseStageEffect { ConditionId = WeighedDown.ID, Severity = 5}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Clumsy.ID, Severity = 2},
                    new ConditionDiseaseStageEffect { ConditionId = WeighedDown.ID, Severity = 10}
                }
            };
        }
    }
}
