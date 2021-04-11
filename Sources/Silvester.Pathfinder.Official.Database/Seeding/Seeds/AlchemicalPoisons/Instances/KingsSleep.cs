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
    public class KingsSleep : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("7d31dbce-9230-4960-99cc-71de51c18977");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "King's Sleep",
                ItemLevel = 18,
                Price = 400000,
                Usage = "Held in 1 hand",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id,
                DifficultyCheck = 41,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "1 Day",
                MaximumDuration = "Indefinite",
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Poison";
            yield return "Consumable";
            yield return "Ingested";
            yield return "Virulent";
        }

        protected override IEnumerable<AlchemicalPoisonDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("620d976a-9aa5-421e-a5a0-124b60cdc8db"), Text = "King’s sleep is an insidious long-term poison that can seem like a disease or even death from natural causes on a venerable target. The drained condition from king’s sleep is cumulative with each failed save and can’t be removed while the poison lasts." };
        }

        protected override IEnumerable<AlchemicalPoisonStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Day",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Drained.ID, Severity = 1}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Day",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Drained.ID, Severity = 1}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Day",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Drained.ID, Severity = 2}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("9541ee54-4d19-4904-9161-9412cd2b7905"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 552
            };
        }
    }
}
