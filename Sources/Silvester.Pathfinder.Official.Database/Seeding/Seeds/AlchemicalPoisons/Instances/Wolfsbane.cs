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
    public class Wolfsbane : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("25956d4a-b3ee-49fe-9660-b1ee2b67b1de");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Wolfsbane",
                ItemLevel = 10,
                Price = 15500,
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
                Name = "Wolfsbane",
                DifficultyCheck = 30,
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
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("e864228b-0a29-43de-bebb-175ea6468573"), Text = "Wolfsbane appears in folklore for its link to werecreatures. If you are afflicted with lycanthropy and survive stage 3 of wolfsbane, you’re immediately cured of the lycanthropy." };
        }

        protected override IEnumerable<PoisonEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("4e559a7a-d1c2-4c97-841a-56a1133d5dd0"),
                Duration = "1 Minute",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("2499800c-521f-414e-92f2-5df2fcfafe36"), Damage = "12d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("58e92f10-359f-4c0c-8de8-41b297e185f4"),
                Duration = "1 Minute",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("2499800c-521f-414e-92f2-5df2fcfafe36"), Damage = "16d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("58e92f10-359f-4c0c-8de8-41b297e185f4"),
                Duration = "1 Minute",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("53314a91-0060-4517-8192-fa4fa6cacf74"), Damage = "20d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("67140723-8d8e-46a2-8971-c7a5ca9b63f8"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 553
            };
        }
    }
}
