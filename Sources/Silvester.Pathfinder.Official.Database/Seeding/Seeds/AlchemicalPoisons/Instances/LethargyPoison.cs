using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class LethargyPoison : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("ed3a6476-d01d-44c9-a3a5-72e753c48be5");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Lethargy Poison",
                ItemLevel = 2,
                Price = 700,
                Usage = "Held in s hands",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("Two Actions").Id,
            };
        }

        protected override PoisonEffect GetPoisonEffect(AlchemicalPoisonSeeder seeder)
        {
            return new PoisonEffect
            {
                Id = Guid.Parse(""),
                Name = "Lethargy Poison",
                DifficultyCheck = 18,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "Immediate",
                MaximumDuration = "4 Hours",
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Poison";
            yield return "Consumable";
            yield return "Uncommon";
            yield return "Incapacitation";
            yield return "Injury";
            yield return "Sleep";
        }

        protected override IEnumerable<AlchemicalPoisonDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("ed3a6476-d01d-44c9-a3a5-72e753c48be5"), Text = "Lethargy poison is commonly used in hit-and-run tactics by drow and others who want their victims alive; the ambusher retreats until the poison sets in and the victim falls unconscious. Further exposure to lethargy poison does not require the target to attempt additional saving throws; only failing an saving throw against an ongoing exposure can progress its stage." };
        }

        protected override IEnumerable<PoisonEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("6c9e289f-c6e9-4c1d-bdf8-2f27a8e0f286"),
                Duration = "1 Round",
                Effects = new PoisonEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("d465d853-ec47-4dae-8127-12eb28f7772e"),  ConditionId = Slowed.ID, Severity = 1}
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("7b554a0b-5001-4e46-98a7-fce18cc80c10"),
                Duration = "1 Minute",
                Effects = new PoisonEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("d879fa2d-c94f-4800-bea2-dae5fbae818e"),  ConditionId = Slowed.ID, Severity = 1}
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("fcad32cd-f3ac-4cb6-a108-f54b16dcbbf9"),
                Duration = "1 Round",
                Effects = new PoisonEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("f07abe26-4519-452c-9ede-9e1324f0af60"),  ConditionId = Unconscious.ID},
                    new OtherPoisonStageEffect { Id = Guid.Parse("c6063c4e-4644-4972-baa0-fab5ae0eb0b0"),  Effect = "You cannot Perception check to wake up from unconsciousness."}
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("a85df2c1-e5f2-448b-ac85-03c85869417d"),
                Duration = "1d4 Hours",
                Effects = new PoisonEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("33a4cee8-887e-4b38-b519-1d31ff816a33"),  ConditionId = Unconscious.ID},
                    new OtherPoisonStageEffect { Id = Guid.Parse("a4bc689a-bae6-4049-9da8-b5c4eb8a75b6"),  Effect = "You cannot Perception check to wake up from unconsciousness."}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed3a6476-d01d-44c9-a3a5-72e753c48be5"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 552
            };
        }
    }
}
