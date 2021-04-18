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
    public class NettleweedResidue : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("427af463-394a-423e-be07-d4788fc27ec7");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Nettleweed Residue",
                ItemLevel = 8,
                Price = 7500,
                Usage = "Held in 2 hands",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id
            };
        }

        protected override StaggeredEffect GetPoisonEffect(AlchemicalPoisonSeeder seeder)
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("990ea5c3-22bc-4c51-9aca-c533e5bddd88"),
                DifficultyCheck = 27,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "1 Minute",
                MaximumDuration = "6 Minutes",
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Poison";
            yield return "Consumable";
            yield return "Contact";
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7391054-edfc-4951-8efc-8b995fde8148"), Text = "Concentrated sap of stinging weeds makes an effective toxin." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("12cf4b7b-4c31-43de-b96f-9b8d1999ecf3"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("452e8475-cdf0-44a4-ba16-09560013f210"), Damage = "8d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("a8c16f0b-6882-4350-8778-9a5c81b30693"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("7837cfb0-e1b7-49d1-974b-e54579663570"), Damage = "10d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("eecd7522-686e-4a45-8171-dfdd005905b6"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("eecd7522-686e-4a45-8171-dfdd005905b6"), Damage = "13d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("d82d7b7d-f861-463d-ba6a-a5f4f331484c"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 553
            };
        }
    }
}
