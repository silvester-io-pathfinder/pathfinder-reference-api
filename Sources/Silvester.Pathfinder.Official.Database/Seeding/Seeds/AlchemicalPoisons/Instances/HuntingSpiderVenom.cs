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
    public class HuntingSpiderVenom : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("1e830309-8b32-4860-85d0-a704be45b0f6");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Hunting Spider Venom",
                ItemLevel = 5,
                Price = 2500,
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
                Id = Guid.Parse("02525cd2-d5b9-4e41-a7e7-8ea60b3b105e"),
                DifficultyCheck = 21,
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
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("84e7645e-26c9-436c-824e-f485cba68ba0"), Text = "This venom erodes its target’s defenses, aiding the spider in securing prey." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("67839e5e-b6f6-4ce8-b536-10004c043041"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("a78408c4-2205-480a-8609-2cd28a755fe1"), Damage = "1d10", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("58936569-a213-4c32-bad0-8dd632e8c143"),  ConditionId = FlatFooted.ID}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("6cb56422-0099-4a94-a59d-46cb9ca5f2f6"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("0727811c-bfd4-4a38-9166-c94d17fd239f"), Damage = "1d12", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("a4706319-051d-4c98-af73-398cdccec687"),  ConditionId = Clumsy.ID, Severity = 1},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("eb2dce7e-db4d-4bac-a61c-b3e9aea525ed"),  ConditionId = FlatFooted.ID}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("238e7d05-3376-4c19-999f-2675ae1940ca"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("de183ff8-e257-433d-8768-043895f2ade5"), Damage = "2d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("eeb7db98-674f-4052-b325-60e52efca32d"),  ConditionId = Clumsy.ID, Severity = 2},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("e2fcf7f8-043e-44c8-a54b-c30295bd1fff"),  ConditionId = FlatFooted.ID}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("20c6c8fb-0561-4b49-8649-9f894536f993"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 552
            };
        }
    }
}
