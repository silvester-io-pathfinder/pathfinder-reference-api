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
    public class ShadowEssence : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("eec5e097-c60a-4a1d-91d3-57bcf30e6a31");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Shadow Essence",
                ItemLevel = 10,
                Price = 16000,
                Usage = "Held in 2 hands",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("Teo Actions").Id,
                DifficultyCheck = 29,
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
            yield return "Negative";
        }

        protected override IEnumerable<AlchemicalPoisonDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("44e8074e-5cc8-46f9-8829-7ab92e42f176"), Text = "Distilled from the Plane of Shadow, this oily substance imposes tenebrous effects. The enfeebled condition from shadow essence lasts for 24 hours." };
        }

        protected override IEnumerable<AlchemicalPoisonStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "3d6", DamageType = seeder.GetDamageTypeByName("Negative")},
                    new DamageAlchemicalPoisonStageEffect {Damage = "2d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "3d6", DamageType = seeder.GetDamageTypeByName("Negative")},
                    new DamageAlchemicalPoisonStageEffect {Damage = "2d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Enfeebled.ID, Severity = 1}
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "3d6", DamageType = seeder.GetDamageTypeByName("Negative")},
                    new DamageAlchemicalPoisonStageEffect {Damage = "2d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionAlchemicalPoisonStageEffect { ConditionId = Enfeebled.ID, Severity = 2}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("fde5577d-2503-4d43-928a-228fcc34d11f"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 553
            };
        }
    }
}
