using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases.Instances
{
    public class Fleshgout : AbstractDiseaseTemplate
    {
        public static readonly Guid ID = Guid.Parse("390c8350-3289-4f72-92ad-3490b8d0f8b5");

        public override Disease GetDisease(DiseaseSeeder seeder)
        {
            return new Disease
            {
                Id = ID,
                Name = "Fleshgout",
                Description = "A ghonhatine’s vomit carries an awful disease that, over time, can cause a suffering creature’s flesh to develop painful boils that eventually slough away, leaving gaping wounds",
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                DifficultyCheck = 28,
                Onset = "Immediate"
            };
        }

        public override SourcePage? GetSourcePage(DiseaseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f3561ed-7175-4f9f-b654-8e25dee7c37b"),
                SourceId = seeder.GetSourceByName("Bestiary 2").Id,
                Page = 119
            };
        }

        public override IEnumerable<string> GetTraits()
        {
            yield break;
        }

        public override IEnumerable<DiseaseStage> GetDiseaseStages(DiseaseSeeder seeder)
        {
            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromHours(4),
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
                    new ConditionDiseaseStageEffect { ConditionId = Enfeebled.ID, Severity = 1},
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 1}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Enfeebled.ID, Severity = 2},
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 2}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Enfeebled.ID, Severity = 2},
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 3}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Unconscious.ID},
                    new ConditionDiseaseStageEffect { ConditionId = Enfeebled.ID, Severity = 2},
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 4}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Dead.ID}
                }
            };
        }
    }
}
