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
    public class GiantWaspVenom : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("862bacf9-a11f-4f56-8c94-2452d636db79");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Giant Wasp Venom",
                ItemLevel = 7,
                Price = 5500,
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
                Name = "Giant Wasp Venom",
                DifficultyCheck = 25,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "Immedate",
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
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("2d4bb8d3-f0fc-4e20-a407-a73f2824d244"), Text = "Giant wasp venom interferes with a victim’s movement." };
        }

        protected override IEnumerable<PoisonEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("1c67cd5b-de98-4ae0-bd21-ee9f106e14ad"),
                Duration = "1 Round",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("cad292b2-f6c3-4ea9-8dd9-751959708833"), Damage = "2d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("1ddc185b-02a4-4767-b112-29d040653039"),  ConditionId = Clumsy.ID, Severity = 1}
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("34ec0065-42d6-47b4-bf69-d973dba2ef14"),
                Duration = "1 Round",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("ed57f33c-ff21-4f03-86d2-8990ac64aef9"), Damage = "3d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("fc788e66-b377-49af-b940-464150d24edf"),  ConditionId = Clumsy.ID, Severity = 2}
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("c0951b2e-31d9-47da-a8d9-7d8b621fc821"),
                Duration = "1 Round",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("9ba4b270-c48a-40f7-b521-37c356429c7d"), Damage = "4d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("5f9c4c7c-f785-4247-ae9c-8fe76d687bb5"),  ConditionId = Clumsy.ID, Severity = 2}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("5b2cfa04-9394-4ab9-a5ee-6dba2a814fbc"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 552
            };
        }
    }
}
