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
    public class GiantCentipedeVenom : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("acc877c9-ea44-4977-b0da-6bf6ec70922a");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Giant Centipede Venom",
                ItemLevel = 1,
                Price = 400,
                Usage = "Held in 2 hands",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("Two Actions").Id,
                DifficultyCheck = 17,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "Immediate",
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
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("e9c5a72e-0a96-4f96-ba1f-a64036c4cfda"), Text = "Giant centipede venom causes severe muscle stiffness." };
        }

        protected override IEnumerable<AlchemicalPoisonStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "1d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "1d8", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = FlatFooted.ID}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "1d12", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = FlatFooted.ID},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Clumsy.ID, Severity = 1}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("b30b8cbc-1230-4e7c-be11-8f7a995a7cf1"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 551
            };
        }
    }
}
