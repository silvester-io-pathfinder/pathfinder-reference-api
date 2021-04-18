using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons
{
    public abstract class AbstractAlchemicalPoisonTemplate
    {
        public void Seed(AlchemicalPoisonSeeder seeder)
        {
            AlchemicalPoison poison = GetAlchemicalPoison(seeder);

            SourcePage? sourcePage = GetSourcePage(seeder);
            if (sourcePage != null)
            {
                seeder.Builder.AddData(sourcePage);
                poison.SourcePageId = sourcePage.Id;
            }

            foreach (Trait trait in seeder.FilterTraits(GetTraits().ToArray()))
            {
                seeder.Builder.HasJoinData((poison, trait));
            }

            TextBlock[] details = GetDetailBlocks().ToArray();
            for(int i = 0; i < details.Length; i ++)
            {
                TextBlock detail = details[i];
                detail.Order = i;
                detail.OwnerId = poison.Id;
                seeder.Builder.AddOwnedData((AlchemicalPoison e) => e.Details, detail);
            }

            SeedPoisonEffect(seeder, poison);

            seeder.Builder.AddData(poison);
        }

        private void SeedPoisonEffect(AlchemicalPoisonSeeder seeder, AlchemicalPoison poison)
        {
            StaggeredEffect poisonEffect = GetPoisonEffect(seeder);
            seeder.Builder.AddData(poisonEffect);

            poison.EffectId = poisonEffect.Id;

            StaggeredEffectStage[] stages = GetAlchemicalPoisonStages(seeder).ToArray();
            for (int i = 0; i < stages.Length; i++)
            {
                StaggeredEffectStage poisonEffectStage = stages[i];
                SeedPoisonEffectStage(seeder, poisonEffect.Id, i + 1, poisonEffectStage);
            }
        }

        private static void SeedPoisonEffectStage(AlchemicalPoisonSeeder seeder, Guid poisonEffectId, int stageNumber, StaggeredEffectStage poisonEffectStage)
        {
            poisonEffectStage.StaggeredEffectId = poisonEffectId;
            poisonEffectStage.Stage = stageNumber;

            foreach (StaggeredEffectStageEffect stageEffect in poisonEffectStage.Effects)
            {
                SeedPoisonEffectStageEffect(seeder, poisonEffectStage, stageEffect);
            }
            poisonEffectStage.Effects = new StaggeredEffectStageEffect[] { };
            
            seeder.Builder.AddData(poisonEffectStage);
        }

        private static void SeedPoisonEffectStageEffect(AlchemicalPoisonSeeder seeder, StaggeredEffectStage poisonEffectStage, StaggeredEffectStageEffect stageEffect)
        {
            stageEffect.StaggeredEffectStageId = poisonEffectStage.Id;
            seeder.Builder.AddData(stageEffect.GetType(), stageEffect);
        }

        protected abstract AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder);
        protected abstract StaggeredEffect GetPoisonEffect(AlchemicalPoisonSeeder seeder);
        protected abstract SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder);
        protected abstract IEnumerable<string> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetailBlocks();
        protected abstract IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder);
    }
}
