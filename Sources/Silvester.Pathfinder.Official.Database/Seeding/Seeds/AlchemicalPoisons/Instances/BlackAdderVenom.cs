using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class BlackAdderVenom : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("c65fd194-6210-42c8-80a2-b54ff81b6585");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Black Adder Venom",
                ItemLevel = 2,
                Price = 600,
                Usage = "Held in 2 hands",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("Two Actions").Id,
            };
        }

        protected override StaggeredEffect GetPoisonEffect(AlchemicalPoisonSeeder seeder)
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("9ab302d1-94a8-46c3-8ce5-f658e4e63531"),
                DifficultyCheck = 18,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                MaximumDuration = "3 Rounds",
                Onset = "Immediate"
            };
        }
        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Poison";
            yield return "Consumable";
            yield return "Injury";
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("26dd2686-7c61-4c86-8724-6d2e336401a0"), Text = "Adder venom is a simple but effective way to enhance a weapon." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("d44a502a-e5f1-4014-899a-1b9ac8425764"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("7a7a221e-1e36-4169-9184-af24aeb92769"), Damage = "1d8", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("7e0f3f16-8979-426b-878a-ed4f6223a119"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("bdb667b8-4850-4ca8-837c-9b8126773640"), Damage = "2d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("5033a055-e80f-43a5-b42a-14262a046351"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 551
            };
        }
    }
}
