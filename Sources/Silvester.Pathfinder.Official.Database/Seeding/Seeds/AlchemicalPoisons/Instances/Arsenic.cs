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
    public class Arsenic : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("b28f4309-cc04-4522-8837-b653995b3028");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Arsenic",
                ItemLevel = 1,
                Price = 300,
                Usage = "Held in 1 hand",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id,
                DifficultyCheck = 18,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "10 Minutes",
                MaximumDuration = ""
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
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("ab9af6c8-886c-4cc4-8347-d5d5b6c520e5"), Text = "This toxin is a compound of arsenic and other substances. You can’t reduce your sickened condition while affected." };
        }

        protected override IEnumerable<AlchemicalPoisonStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Minute",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Sickened.ID, Severity = 1},
                    new DamageAlchemicalPoisonStageEffect {Damage = "1d4", DamageType = seeder.GetDamageTypeByName("Poison")}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Minute",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Sickened.ID, Severity = 2},
                    new DamageAlchemicalPoisonStageEffect {Damage = "1d6", DamageType = seeder.GetDamageTypeByName("Poison")}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Minute",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Sickened.ID, Severity = 3},
                    new DamageAlchemicalPoisonStageEffect {Damage = "2d6", DamageType = seeder.GetDamageTypeByName("Poison")}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c09132c-90a6-4d8f-a62e-64faf7f8ffca"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 550
            };
        }
    }
}
