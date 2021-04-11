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
    public class GiantWaspVenom : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("862bacf9-a11f-4f56-8c94-2452d636db79");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Giant Wasp Venom",
                ItemLevel = 7,
                Price = 5500,
                Usage = "Held in 2 hands",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("Two Actions").Id,
                DifficultyCheck = 25,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "Immedate",
                MaximumDuration = "6 Rounds",
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Poison";
            yield return "Consumable";
            yield return "Injury";
        }

        protected override IEnumerable<AlchemicalPoisonDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("2d4bb8d3-f0fc-4e20-a407-a73f2824d244"), Text = "Giant wasp venom interferes with a victim’s movement." };
        }

        protected override IEnumerable<AlchemicalPoisonStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "2d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Clumsy.ID, Severity = 1}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "3d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Clumsy.ID, Severity = 2}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "4d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Clumsy.ID, Severity = 2}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("5b2cfa04-9394-4ab9-a5ee-6dba2a814fbc"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 552
            };
        }
    }
}
