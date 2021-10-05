using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Diseases.Instances
{
    public class BrainWorms : Template
    {
        public static readonly Guid ID = Guid.Parse("94d803e5-9777-4b7f-96bf-0df87af5455f");

        public override Disease GetDisease()
        {
            return new Disease
            {
                Id = ID,
                Name = "Brain Worms",
                Description = "Scholars suspect these brain parasites have an otherworldly or extraplanar origin. Though transmitted by the bites of infected targets, the disease remains relatively rare—most hosts are killed by the effects before they can pass it on. While infected, whenever you attack due to confusion, you bite your target (if you don’t have a jaws or fangs attack, you deal piercing damage as an unarmed attack with damage equal to your lowest unarmed attack).",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DifficultyCheck = 28,
                Onset = "1 Day"
            };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a2a53bc0-a6be-43ed-9427-b54ab63abdc3"),
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
                    new ConditionDiseaseStageEffect { ConditionId = Stupefied.ID, Severity = 2}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Stupefied.ID, Severity = 2},
                    new OtherDiseaseStageEffect {Effect = "Whenever you take damage, you must succeed at a Will save against the disease’s DC or become confused for 1 round."}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Stupefied.ID, Severity = 3},
                    new OtherDiseaseStageEffect {Effect = "Whenever you take damage, you must succeed at a Will save against the disease’s DC or become confused for 1 minute."}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Stupefied.ID, Severity = 4},
                    new ConditionDiseaseStageEffect { ConditionId = Confused.ID},
                    new OtherDiseaseStageEffect {Effect = "Damage does not end the confused condition."}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Unconscious.ID},
                }
            };

            yield return new DiseaseStage
            {
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Dead.ID},
                }
            };
        }
    }
}
