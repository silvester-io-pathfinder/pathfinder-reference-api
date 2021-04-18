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
    public class NightmareVapor : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("d493d861-70f0-4362-a954-2d0609869352");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Nightmare Vapor",
                ItemLevel = 16,
                Price = 140000,
                Usage = "Held in 1 hand",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id,
            };
        }

        protected override StaggeredEffect GetPoisonEffect(AlchemicalPoisonSeeder seeder)
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("a219e285-2d4f-4720-8266-1aefc03cd7ae"),
                DifficultyCheck = 36,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "1 Round",
                MaximumDuration = "6 Rounds",
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Poison";
            yield return "Consumable";
            yield return "Inhaled";
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7f2675e-38a7-4d2e-bb3f-a893a4538f22"), Text = "Purportedly sourced from any number of outlandish locales, nightmare vapor is most often created by boiling the sweat collected from humanoids caught in the throes of terrible nightmares." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("e229a0be-7872-494f-8b8d-0d9243b55209"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("2fb6cbeb-862a-47d6-8a14-beba496fa865"),  ConditionId = Confused.ID}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("61776e14-9ede-46f4-a06c-159dc5449417"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {                    
                    new ConditionPoisonStageEffect { Id = Guid.Parse("e901e773-4ddd-45b3-b08a-dfcfa2df5bf7"),  ConditionId = Confused.ID},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("040091a6-d7c9-4d09-892d-8b47780ad8ba"),  ConditionId = FlatFooted.ID}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("c818b8ed-9c57-4b0e-91be-91d714eb84be"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("a3fe5d9e-596c-4a4c-9bba-15c06efd2771"),  ConditionId = Confused.ID},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("597f934c-9fdc-4b2f-a1e8-22e3b4727bf6"),  ConditionId = FlatFooted.ID},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("4e11fe72-86a4-462a-8e76-fe7a1a29af16"),  ConditionId = Stupefied.ID, Severity = 2}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbac34ef-0bee-4110-b002-b65aab1130db"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 553
            };
        }
    }
}
