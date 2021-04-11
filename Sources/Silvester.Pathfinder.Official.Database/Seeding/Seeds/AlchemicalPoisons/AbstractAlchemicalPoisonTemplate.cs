using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
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
                poison.SourcePageId = sourcePage.SourceId;
            }

            foreach (AlchemicalPoisonDetailBlock detailBlock in GetDetailBlocks())
            {
                detailBlock.AlchemicalPoisonId = poison.Id;
                seeder.Builder.AddData(detailBlock);
            }

            SeedPoisonEffect(seeder);

            seeder.Builder.AddData(poison);
        }

        private void SeedPoisonEffect(AlchemicalPoisonSeeder seeder)
        {
            PoisonEffect poisonEffect = GetPoisonEffect(seeder);
            seeder.Builder.AddData(poisonEffect);

            foreach (Trait trait in seeder.FilterTraits(GetTraits().ToArray()))
            {
                seeder.Builder.HasJoinData((poisonEffect, trait));
            }

            PoisonEffectStage[] stages = GetAlchemicalPoisonStages(seeder).ToArray();
            for (int i = 0; i < stages.Length; i++)
            {
                PoisonEffectStage poisonEffectStage = stages[i];
                SeedPoisonEffectStage(seeder, poisonEffect.Id, i + 1, poisonEffectStage);
            }
        }

        private static void SeedPoisonEffectStage(AlchemicalPoisonSeeder seeder, Guid poisonEffectId, int stageNumber, PoisonEffectStage poisonEffectStage)
        {
            poisonEffectStage.PoisonEffectId = poisonEffectId;
            poisonEffectStage.Stage = stageNumber;

            foreach (PoisonEffectStageEffect stageEffect in poisonEffectStage.Effects)
            {
                SeedPoisonEffectStageEffect(seeder, poisonEffectStage, stageEffect);
            }

            poisonEffectStage.Effects = new PoisonEffectStageEffect[] { };
            seeder.Builder.AddData(poisonEffectStage);
        }

        private static void SeedPoisonEffectStageEffect(AlchemicalPoisonSeeder seeder, PoisonEffectStage poisonEffectStage, PoisonEffectStageEffect stageEffect)
        {
            stageEffect.PoisonEffectStageId = poisonEffectStage.Id;
            seeder.Builder.AddData(stageEffect.GetType(), stageEffect);
        }

        protected abstract AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder);
        protected abstract PoisonEffect GetPoisonEffect(AlchemicalPoisonSeeder seeder);
        protected abstract SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder);
        protected abstract IEnumerable<string> GetTraits();
        protected abstract IEnumerable<AlchemicalPoisonDetailBlock> GetDetailBlocks();
        protected abstract IEnumerable<PoisonEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder);
    }
}
