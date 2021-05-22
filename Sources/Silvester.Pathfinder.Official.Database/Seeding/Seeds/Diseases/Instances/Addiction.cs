using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases.Instances
{
    public class Addiction : Template
    {
        public static readonly Guid ID = Guid.Parse("df53fbce-7ea5-4882-8aac-d589381514b2");

        public override Disease GetDisease()
        {
            return new Disease
            {
                Id = ID,
                Name = "Addiction",
                Description = "Track the maximum stage you reach with each drug’s addiction. This maximum stage is separate from your current addiction stage for the drug. The maximum stage can’t be reduced, even if you fully remove the disease. When you take the drug, two things happen: you attempt a saving throw against addiction, and you suppress the effects of addiction for 1 day. Failing a save against addiction caused by taking the drug causes you to go to 1 stage higher than the maximum stage you had previously reached (2 stages higher on a critical failure). If you’re currently suffering from addiction when you attempt a save from taking the drug, you can’t improve your stage; if you succeed at the save, the stage remains the same as it was. When you attempt your save against addiction each week, the stage you are currently at can’t get worse—it can only stay the same or improve. The conditions from addiction can’t be removed while you are affected by the addiction, and suppressing addiction by taking the drug only avoids the effects—it doesn’t remove the disease.",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DifficultyCheck = null,
                Onset = "1 day"
            };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("480e5953-ecf3-4be4-abe8-d2ef95e6dc44"),
                SourceId = GamemasteryGuide.ID,
                Page = 120
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
                Duration = TimeSpan.FromDays(7),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Fatigued.ID},
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(7),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Fatigued.ID},
                    new ConditionDiseaseStageEffect { ConditionId = Sickened.ID, Severity = 1},
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(7),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Fatigued.ID},
                    new ConditionDiseaseStageEffect { ConditionId = Sickened.ID, Severity = 1},
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 1},
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(7),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Fatigued.ID},
                    new ConditionDiseaseStageEffect { ConditionId = Sickened.ID, Severity = 2},
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 2},
                    new ConditionDiseaseStageEffect { ConditionId = Stupefied.ID, Severity = 2},
                }
            };
        }
    }
}
