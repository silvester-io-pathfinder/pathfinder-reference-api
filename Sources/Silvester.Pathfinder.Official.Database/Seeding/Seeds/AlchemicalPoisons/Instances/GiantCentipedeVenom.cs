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
            };
        }

        protected override PoisonEffect GetPoisonEffect(AlchemicalPoisonSeeder seeder)
        {
            return new PoisonEffect
            {
                Id = Guid.Parse(""),
                Name = "Giant Centipede Venom",
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

        protected override IEnumerable<PoisonEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("7ab45a14-5323-4788-8547-bde6dcef2eea"),
                Duration = "1 Round",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("a2a670e4-c86f-453c-b5f2-4c55108bf2b2"), Damage = "1d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("18e5d82c-4e9b-4e03-aa6a-7b2506af4227"),
                Duration = "1 Round",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("c2016d79-d34e-40fc-bda1-255c004de10a"), Damage = "1d8", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("c38d3ca0-e6d3-468d-b78f-b16fd0d39bec"),  ConditionId = FlatFooted.ID}
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("1acf2634-6f8e-415c-b5be-929dcbf7c174"),
                Duration = "1 Round",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("e8135bb7-15ea-4a1c-94da-da193525cd2d"), Damage = "1d12", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("195e7a37-1ff5-4c8f-9de4-3b36405c2a01"),  ConditionId = FlatFooted.ID},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("78670bc1-771e-4221-8eca-466d80e3aff2"),  ConditionId = Clumsy.ID, Severity = 1}
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
