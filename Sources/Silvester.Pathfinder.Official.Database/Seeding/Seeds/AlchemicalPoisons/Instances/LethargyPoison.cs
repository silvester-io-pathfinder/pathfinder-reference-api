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

        protected override IEnumerable<AlchemicalPoisonStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Slowed.ID, Severity = 1}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Minute",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Slowed.ID, Severity = 1}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Unconscious.ID},
                    new OtherAlchemicalPoisonStageEffect { Effect = "You cannot Perception check to wake up from unconsciousness."}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1d4 Hours",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Unconscious.ID},
                    new OtherAlchemicalPoisonStageEffect { Effect = "You cannot Perception check to wake up from unconsciousness."}
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
