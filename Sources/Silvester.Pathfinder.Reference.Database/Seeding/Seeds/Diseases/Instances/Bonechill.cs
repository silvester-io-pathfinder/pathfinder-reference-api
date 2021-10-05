using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Diseases.Instances
{
    public class Bonechill : Template
    {
        public static readonly Guid ID = Guid.Parse("0420dbd7-79bc-420d-b926-6f1d66f6d14e");

        public override Disease GetDisease()
        {
            return new Disease
            {
                Id = ID,
                Name = "Bonechill",
                Description = "If you are wounded and exposed to persistent cold, you might contract bonechill.",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DifficultyCheck = 20,
                Onset = "1 Day"
            };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e838c4f-13ff-4587-a840-f4bc36a01360"),
                SourceId = GamemasteryGuide.ID,
                Page = 118
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Disease.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Primal.ID;
        }

        public override IEnumerable<DiseaseStage> GetDiseaseStages()
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
