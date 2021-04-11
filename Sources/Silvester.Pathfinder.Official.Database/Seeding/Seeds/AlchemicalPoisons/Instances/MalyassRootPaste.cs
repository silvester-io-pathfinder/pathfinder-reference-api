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
    public class MalyassRootPaste : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("aef8461a-019a-4c5e-baeb-949f8ebd6e66");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Malyass Root Paste",
                ItemLevel = 7,
                Price = 5500,
                Usage = "Held in 2 hands",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("Three Actions").Id,
                DifficultyCheck = 26,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "1 Minute",
                MaximumDuration = "6 Minutes",
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Poison";
            yield return "Consumable";
            yield return "Contact";
        }

        protected override IEnumerable<AlchemicalPoisonDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("42d4e1ff-92b4-4153-b3eb-42ea8d70eb41"), Text = "Malyass root paste sees use to impede opponents in athletic competitions, in addition to espionage and tracking." };
        }

        protected override IEnumerable<AlchemicalPoisonStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Minute",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Clumsy.ID, Severity = 1},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = WeighedDown.ID, Severity = 10},
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Minute",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Clumsy.ID, Severity = 2},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = WeighedDown.ID, Severity = 20},
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "4 Minute",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Clumsy.ID, Severity = 3},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = FlatFooted.ID},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = WeighedDown.ID, Severity = 30},
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("2597f652-2268-4bd5-b1c3-73d4f6df3656"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 552
            };
        }
    }
}
