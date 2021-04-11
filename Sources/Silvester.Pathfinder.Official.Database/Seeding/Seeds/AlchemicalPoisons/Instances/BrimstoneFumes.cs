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
    public class BrimstoneFumes : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("81b07f7b-2e70-4b38-80f7-0b28a4c6f399");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Brimstone Fumes",
                ItemLevel = 16,
                Price = 150000,
                Usage = "Held in 1 hand",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id,
                DifficultyCheck = 36,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "1 Round",
                MaximumDuration = "6 Rounds"
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Poison";
            yield return "Consumable";
            yield return "Evil";
            yield return "Inhaled";
        }

        protected override IEnumerable<AlchemicalPoisonDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("5b28e3fa-1348-41cb-ba9f-25f5230e45d3"), Text = "Fumes from the forges of Hell drain health and strength alike." };
        }

        protected override IEnumerable<AlchemicalPoisonStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "7d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Enfeebled.ID, Severity = 1}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "8d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Enfeebled.ID, Severity = 2}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "10d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Enfeebled.ID, Severity = 3}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("0381fe8b-2404-42fb-9abd-74e28f1401d5"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 551
            };
        }
    }
}
