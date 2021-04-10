using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases.Instances
{
    public class ChokingDeath : AbstractDiseaseTemplate
    {
        public static readonly Guid ID = Guid.Parse("aae01797-c896-4665-9681-4caae8d37800");

        public override Disease GetDisease(DiseaseSeeder seeder)
        {
            return new Disease
            {
                Id = ID,
                Name = "Choking Death",
                Description = "This disease is capable of wiping out nations or even entire continents. A few pockets of the disease still remain in Iobaria, keeping that region’s population sparse.",
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                DifficultyCheck = 22,
                Onset = "1 Day"
            };
        }

        public override SourcePage? GetSourcePage(DiseaseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e5abee1-6553-400c-a667-41bae3f6acfb"),
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
                    new OtherDiseaseStageEffect { Effect = "Hoarse voice, but no other symptoms." }
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
                    new ConditionDiseaseStageEffect { ConditionId = Muted.ID}
                }
            };

            yield return new DiseaseStage
            {
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Dead.ID}
                }
            };
        }
    }
}
