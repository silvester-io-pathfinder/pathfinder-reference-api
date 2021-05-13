using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases.Instances
{
    public class Fleshgout : Template
    {
        public static readonly Guid ID = Guid.Parse("390c8350-3289-4f72-92ad-3490b8d0f8b5");

        public override Disease GetDisease()
        {
            return new Disease
            {
                Id = ID,
                Name = "Fleshgout",
                Description = "A ghonhatine’s vomit carries an awful disease that, over time, can cause a suffering creature’s flesh to develop painful boils that eventually slough away, leaving gaping wounds",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DifficultyCheck = 28,
                Onset = "Immediate"
            };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f3561ed-7175-4f9f-b654-8e25dee7c37b"),
                SourceId = Bestiary2.ID,
                Page = 119
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
