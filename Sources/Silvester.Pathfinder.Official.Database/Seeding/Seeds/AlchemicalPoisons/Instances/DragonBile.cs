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
    public class DragonBile : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("b2e3f38f-f570-4cf8-ba74-633bdc0a1405");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Dragon Bile",
                ItemLevel = 15,
                Price = 92500,
                Usage = "Held in 2 hands",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id,
                DifficultyCheck = 37,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "1 Minute",
                MaximumDuration = "6 Rounds",
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
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("f8d404e3-12fb-4647-adb6-60888962e8f2"), Text = "A mix of digestive juices and green dragon poison glands nauseates the victim as its flesh is digested from within." };
        }

        protected override IEnumerable<AlchemicalPoisonStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "6d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Sickened.ID, Severity = 2}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "7d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Sickened.ID, Severity = 3}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "9d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Sickened.ID, Severity = 4}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("6713fbf0-18f0-453e-a361-b339aafad6f3"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 551
            };
        }
    }
}
