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
    public class WyvernPoison : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("1f8e9d8a-52ba-4b7c-b041-6e797a91e25b");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Wyvern Poison",
                ItemLevel = 8,
                Price = 8000,
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
                Name = "Wyvern Poison",
                DifficultyCheck = 26,
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
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("240bf270-cf24-434c-983a-4b5217b80772"), Text = "Properly harvested and preserved, the poison from a wyvern’s sting is effective and direct." };
        }

        protected override IEnumerable<PoisonEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("a0475e88-48bd-43c8-8d28-5b9e70fd9fd7"),
                Duration = "1 Round",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("73c9d6cf-4a09-4c4f-8092-d498c8d07175"), Damage = "5d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("024442d6-e84c-4eaf-8735-7f8c6e1639c9"),
                Duration = "1 Round",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("a253ee6c-70ae-4468-9a00-a650af66c45e"), Damage = "6d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("ede8cd6e-8055-4b1e-b613-e373cc316074"),
                Duration = "1 Round",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("cd70bf4e-6e09-4447-a5cf-50099eb78ce5"), Damage = "8d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("7124c979-03d4-4edf-84e0-d88c267629cf"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 554
            };
        }
    }
}
