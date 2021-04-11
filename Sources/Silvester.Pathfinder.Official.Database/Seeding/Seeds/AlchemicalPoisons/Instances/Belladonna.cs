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
    public class Belladonna : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("28f803a7-f093-4be7-a3d2-623a77560f93");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Belladonna",
                ItemLevel = 2,
                Price = 500,
                Usage = "Held in 1 hand",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id,
                DifficultyCheck = 19,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "10 Minutes",
                MaximumDuration = "30 Minutes"
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Poison";
            yield return "Consumable";
            yield return "Ingested";
        }

        protected override IEnumerable<AlchemicalPoisonDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("ce438b37-57d0-41eb-83ed-65302a63073b"), Text = "Sometimes called “deadly nightshade,” belladonna is a widely available toxin produced from a plant similar to a tomato." };
        }

        protected override IEnumerable<AlchemicalPoisonStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new AlchemicalPoisonStage
            {
                Duration = "10 Minutes",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Dazzled.ID},
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "10 Minutes",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Sickened.ID, Severity = 1},
                    new DamageAlchemicalPoisonStageEffect {Damage = "1d6", DamageType = seeder.GetDamageTypeByName("Poison")}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Minutes",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Confused.ID},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Sickened.ID, Severity = 1},
                    new DamageAlchemicalPoisonStageEffect {Damage = "1d6", DamageType = seeder.GetDamageTypeByName("Poison")}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("de85d10c-dda0-4b8a-a8c4-75262c40cd56"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 551
            };
        }
    }
}
