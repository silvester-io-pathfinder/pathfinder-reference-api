using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Diseases.Instances
{
    public class Tuberculosis : Template
    {
        public static readonly Guid ID = Guid.Parse("f644ab8a-66c3-4c79-8ac7-b3aeddf5ac19");

        public override Disease GetDisease()
        {
            return new Disease
            {
                Id = ID,
                Name = "Tuberculosis",
                Description = "An extended respiratory disease, tuberculosis can pose particular challenges to spellcasters and some performers due to the intense coughing fits it produces.",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DifficultyCheck = 15,
                Onset = "1 Week"
            };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72e51025-a0c7-4fac-9944-d44fa353d2cf"),
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
                Duration = TimeSpan.FromDays(7),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Carrier.ID}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(7),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Choked.ID, Severity = 5}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(7),
                Effects = new DiseaseStageEffect[]
                {
                    new OtherDiseaseStageEffect { Effect = "Can't recover from the fatigued condition."},
                    new ConditionDiseaseStageEffect { ConditionId = Choked.ID, Severity = 15}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(7),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Unconscious.ID}
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
