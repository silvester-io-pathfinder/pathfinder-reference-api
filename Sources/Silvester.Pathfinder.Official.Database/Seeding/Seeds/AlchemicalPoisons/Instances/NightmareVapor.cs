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
    public class NightmareVapor : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("d493d861-70f0-4362-a954-2d0609869352");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Nightmare Vapor",
                ItemLevel = 16,
                Price = 140000,
                Usage = "Held in 1 hand",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id,
                DifficultyCheck = 36,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "1 Round",
                MaximumDuration = "6 Rounds",
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Poison";
            yield return "Consumable";
            yield return "Inhaled";
        }

        protected override IEnumerable<AlchemicalPoisonDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("a7f2675e-38a7-4d2e-bb3f-a893a4538f22"), Text = "Purportedly sourced from any number of outlandish locales, nightmare vapor is most often created by boiling the sweat collected from humanoids caught in the throes of terrible nightmares." };
        }

        protected override IEnumerable<AlchemicalPoisonStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Confused.ID}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {                    
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Confused.ID},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = FlatFooted.ID}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Confused.ID},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = FlatFooted.ID},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Stupefied.ID, Severity = 2}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbac34ef-0bee-4110-b002-b65aab1130db"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 553
            };
        }
    }
}
