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
    public class BlightburnResin : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("dc73bb29-2a4e-429e-bc99-26d85ae74e1c");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Blightburn Resin",
                ItemLevel = 11,
                Price = 22500,
                Usage = "Held in 2 hands",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id,
            };
        }

        protected override PoisonEffect GetPoisonEffect(AlchemicalPoisonSeeder seeder)
        {
            return new PoisonEffect
            {
                Id = Guid.Parse(""),
                Name = "Blightburn Resin",
                DifficultyCheck = 31,
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
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("785aa516-6335-4df7-9078-4230d4bdf0e7"), Text = "This tacky, hardened sap is harvested from trees infected by fungal blights and exposed to open flames." };
        }

        protected override IEnumerable<PoisonEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("7da7d5d7-7109-4181-8ffe-9a08570559e8"),
                Duration = "1 Round",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("1a85f9c6-5743-433a-a7b3-687ab32981cb"), Damage = "8d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("2853ce52-ea4a-4f9c-b8a3-dded56127ad2"),
                Duration = "1 Round",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("4fd42652-15b6-4286-aa70-b81e34ec90a7"), Damage = "10d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("a1608314-f954-4c33-b6a4-ce5cabc1b52c"),
                Duration = "1 Round",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("d09dd3cd-e867-463c-b911-106662f84b44"), Damage = "15d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("214ab4fd-cbfe-4533-ab5d-e815fb2c48f0"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 551
            };
        }
    }
}
