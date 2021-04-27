using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases.Instances
{
    public class CrimsonOoze : AbstractDiseaseTemplate
    {
        public static readonly Guid ID = Guid.Parse("b11eaf26-1dfd-4ebb-95c4-4ed05af41ec4");

        public override Disease GetDisease()
        {
            return new Disease
            {
                Id = ID,
                Name = "Crimson Ooze",
                Description = "This devastating fungus infects your hand and can be cured by amputating the limb before you reach stage 4.",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DifficultyCheck = 34,
                Onset = "Immediate"
            };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f9d2b87-94d8-4c77-b447-a0ac6afb81f4"),
                SourceId = GamemasteryGuide.ID,
                Page = 119
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Disease.ID;
            yield return Traits.Instances.Virulent.ID;
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
                    new OtherDiseaseStageEffect { Effect = "Using the infected hand deals 3d6 persistent bleed damage."}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Clumsy.ID, Severity = 2},
                    new ConditionDiseaseStageEffect { ConditionId = Stupefied.ID, Severity = 2},
                    new OtherDiseaseStageEffect { Effect = "The infected hand is unusable."}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Clumsy.ID, Severity = 3},
                    new ConditionDiseaseStageEffect { ConditionId = Stupefied.ID, Severity = 3},
                    new OtherDiseaseStageEffect { Effect = "The infected hand is unusable.", Permanent = true}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Confused.ID},
                    new OtherDiseaseStageEffect { Effect = "Damage does not end the confused condition."}
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
