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
    public class SlumberWine : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("1a0af776-3dc1-48f7-bc0a-17c676e4f044");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Slumber Wine",
                ItemLevel = 12,
                Price = 32500,
                Usage = "Held in 1 hand",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id
            };
        }

        protected override StaggeredEffect GetPoisonEffect(AlchemicalPoisonSeeder seeder)
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("4bdc5466-490e-48c2-b346-43bacd734125"),
                DifficultyCheck = 32,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "1 Hour",
                MaximumDuration = "7 Days",
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Poison";
            yield return "Consumable";
            yield return "Ingested";
            yield return "Sleep";
        }

        protected override IEnumerable<AlchemicalPoisonDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("a699aced-f89e-4a8e-b70e-f46ef9abdbd3"), Text = "Slumber wine sees its greatest use in games of intrigue, where an absence can be more devastating than injury. Characters unconscious from slumber wine can’t wake up by any means while the poison lasts, don’t need to eat or drink while unconscious in this way, and appear to be recently dead unless an examiner succeeds at a DC 40 Medicine check." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("1ac15651-b0d8-4677-bae9-f6e3d7d63d95"),
                Duration = "1 Day",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("caf16477-a14f-4430-aeb3-098cba159e84"),  ConditionId = Unconscious.ID}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("4c718a24-8c01-48c3-bd5c-f4df12db2edc"),
                Duration = "2 Days",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("3b935c66-65ea-48c8-95bf-06adb04e8b49"),  ConditionId = Unconscious.ID}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("e158a6d9-59bd-45e3-ac4b-62c3bd13f0b9"),
                Duration = "3 Days",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("f8114adf-1e3e-4056-9fac-50e6972e782c"),  ConditionId = Unconscious.ID}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("8885d836-cabf-4a53-a3f2-8d0d6a6a9bff"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 553
            };
        }
    }
}
