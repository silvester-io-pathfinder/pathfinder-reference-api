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
    public class GiantScorpionVenom : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("7b143b21-75a9-4d41-9c09-1e4a872526b9");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Giant Scorpion Venom",
                ItemLevel = 6,
                Price = 4000,
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
                Id = Guid.Parse("330553c5-7739-45cd-b99e-0f3bd85d5f8d"),
                DifficultyCheck = 22,
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

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("39eeb491-4cff-4764-89d2-9ce910775200"), Text = "Scorpion venom is excruciating and its effects are somewhat debilitating." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("89bdb239-6d05-463b-8cba-8139bc50e0f9"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("14fb278e-8a07-4a78-ba04-76ba5cea9530"), Damage = "1d10", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("96174e93-daf0-457c-8122-33dad6e29aaf"),  ConditionId = Enfeebled.ID, Severity = 1}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("6cbcf457-9203-44fb-a882-4c0886e3c735"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("ea08a570-60de-4df2-8527-9f7788b5ecf3"), Damage = "2d10", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("c442ad47-f2f7-40e9-86c4-536f0fad0912"),  ConditionId = Enfeebled.ID, Severity = 1}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("e57dcb4e-11ad-4431-8638-776ee1bf0b24"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("8d5e5a88-1588-47aa-8564-6113fffbebc5"), Damage = "2d10", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("8885ee16-dcd3-4d91-bd14-8c6aa1c36326"),  ConditionId = Enfeebled.ID, Severity = 2}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4412b0d-a84d-4bc3-9430-41e015d7632b"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 551
            };
        }
    }
}
