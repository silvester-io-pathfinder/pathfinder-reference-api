using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases.Instances
{
    public class CocytanFilth : Template
    {
        public static readonly Guid ID = Guid.Parse("131aef55-4306-47c2-a9d6-3200c8146154");

        public override Disease GetDisease()
        {
            return new Disease
            {
                Id = ID,
                Name = "Cocytan Filth",
                Description = "No description was provided for this disease.",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DifficultyCheck = 18,
                Onset = "1d4 Days"
            };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1960dd05-ab39-4e03-9913-43f1d1b6a1b2"),
                SourceId = Bestiary2.ID,
                Page = 72
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
                Duration = TimeSpan.FromDays(4),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Enfeebled.ID, Severity = 1}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Enfeebled.ID, Severity = 2}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Enfeebled.ID, Severity = 3}
                }
            };
        }
    }
}
