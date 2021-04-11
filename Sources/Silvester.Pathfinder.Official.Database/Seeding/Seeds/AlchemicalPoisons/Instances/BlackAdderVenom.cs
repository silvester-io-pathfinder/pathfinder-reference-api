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
                DifficultyCheck = 18,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                MaximumDuration = "3 Rounds"
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
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("26dd2686-7c61-4c86-8724-6d2e336401a0"), Text = "Adder venom is a simple but effective way to enhance a weapon." };
        }

        protected override IEnumerable<AlchemicalPoisonStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "1d8", DamageType = seeder.GetDamageTypeByName("Poison")},
                }
            };

            yield return new AlchemicalPoisonStage
            {
                Duration = "1 Round",
                Effects = new AlchemicalPoisonStageEffect[]
                {
                    new DamageAlchemicalPoisonStageEffect {Damage = "2d6", DamageType = seeder.GetDamageTypeByName("Poison")},
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
