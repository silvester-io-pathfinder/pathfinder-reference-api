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
    public class LichDust : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("949064c1-4862-4a51-a4fe-8ac7c91559d1");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Lich Dust",
                ItemLevel = 9,
                Price = 11000,
                Usage = "Held in 1 hand",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id
            };
        }

        protected override PoisonEffect GetPoisonEffect(AlchemicalPoisonSeeder seeder)
        {
            return new PoisonEffect
            {
                Id = Guid.Parse(""),
                Name = "Lich Dust",
                DifficultyCheck = 28,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "10 Minutes",
                MaximumDuration = "6 Minutes",
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
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("d4ce3729-a117-4501-b8b3-2526bfb0ff43"), Text = "Dust salvaged from the remains of a destroyed lich has paralytic properties that make it a valuable poison." };
        }

        protected override IEnumerable<PoisonEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("fd3da93d-0239-4e54-b076-069bbdb0aaac"),
                Duration = "1 Minute",
                Effects = new PoisonEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("9bff1446-c02c-46f6-8138-1801cb3f549e"),  ConditionId = Fatigued.ID}
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("d4585a9b-1f6e-4626-89e0-54428475754c"),
                Duration = "1 Minute",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("27a4d185-f05c-40d9-950d-f1919356ad85"), Damage = "5d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("05ac86bb-0e64-4c15-91db-dec7da56acd4"),  ConditionId = Fatigued.ID}
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("8dc1ed03-ff8b-49a0-bbf3-6ccabf16b382"),
                Duration = "1 Minute",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("a7f081b2-87db-4a04-91b9-9fa81352e936"), Damage = "5d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("903e1d6d-379c-4223-8032-88bc21d562e6"),  ConditionId = Fatigued.ID},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("e8c54635-1a96-4cb1-9175-68f7d7378b45"),  ConditionId = Paralyzed.ID},
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ccc8202-a856-4b7b-8660-03390c20d026"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 552
            };
        }
    }
}
