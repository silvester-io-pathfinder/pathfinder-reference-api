using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class LethargyPoison : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("ed3a6476-d01d-44c9-a3a5-72e753c48be5");

        protected override AlchemicalPoison GetAlchemicalPoison()
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Lethargy Poison",
                ItemLevel = 2,
                Price = 700,
                Usage = "Held in s hands",
                BulkId = Bulks.Instances.LightBulk.ID,
                ActionId = Interact.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
            };
        }

        protected override StaggeredEffect GetPoisonEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("0cad04aa-c37a-40ba-bc39-d936c09a63ed"),
                DifficultyCheck = 18,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Onset = "Immediate",
                MaximumDuration = "4 Hours",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Poison.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Injury.ID;
            yield return Traits.Instances.Sleep.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ed3a6476-d01d-44c9-a3a5-72e753c48be5"), Text = "Lethargy poison is commonly used in hit-and-run tactics by drow and others who want their victims alive; the ambusher retreats until the poison sets in and the victim falls unconscious. Further exposure to lethargy poison does not require the target to attempt additional saving throws; only failing an saving throw against an ongoing exposure can progress its stage." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages()
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("6c9e289f-c6e9-4c1d-bdf8-2f27a8e0f286"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("d465d853-ec47-4dae-8127-12eb28f7772e"),  ConditionId = Slowed.ID, Severity = 1}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("7b554a0b-5001-4e46-98a7-fce18cc80c10"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("d879fa2d-c94f-4800-bea2-dae5fbae818e"),  ConditionId = Slowed.ID, Severity = 1}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("fcad32cd-f3ac-4cb6-a108-f54b16dcbbf9"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("f07abe26-4519-452c-9ede-9e1324f0af60"),  ConditionId = Unconscious.ID},
                    new OtherPoisonStageEffect { Id = Guid.Parse("c6063c4e-4644-4972-baa0-fab5ae0eb0b0"),  Effect = "You cannot Perception check to wake up from unconsciousness."}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("a85df2c1-e5f2-448b-ac85-03c85869417d"),
                Duration = "1d4 Hours",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("33a4cee8-887e-4b38-b519-1d31ff816a33"),  ConditionId = Unconscious.ID},
                    new OtherPoisonStageEffect { Id = Guid.Parse("a4bc689a-bae6-4049-9da8-b5c4eb8a75b6"),  Effect = "You cannot Perception check to wake up from unconsciousness."}
                }
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed3a6476-d01d-44c9-a3a5-72e753c48be5"),
                SourceId = CoreRulebook.ID,
                Page = 552
            };
        }
    }
}
