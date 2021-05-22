using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons
{
    public abstract class Template : EntityTemplate<AlchemicalPoison>
    {
        protected override AlchemicalPoison GetEntity(ModelBuilder builder)
        {
            AlchemicalPoison poison = GetAlchemicalPoison();

            builder.AddSourcePage(poison, GetSourcePage(), e => e.SourcePage);
            builder.AddTraits(poison, GetTraits());
            builder.AddTextBlocks(poison, GetDetailBlocks(), e => e.Details);

            SeedPoisonEffect(builder, poison);

            return poison;
        }

        private void SeedPoisonEffect(ModelBuilder builder, AlchemicalPoison poison)
        {
            StaggeredEffect poisonEffect = GetPoisonEffect();
            builder.AddData(poisonEffect);

            poison.EffectId = poisonEffect.Id;

            StaggeredEffectStage[] stages = GetAlchemicalPoisonStages().ToArray();
            for (int i = 0; i < stages.Length; i++)
            {
                StaggeredEffectStage poisonEffectStage = stages[i];
                SeedPoisonEffectStage(builder, poisonEffect.Id, i + 1, poisonEffectStage);
            }
        }

        private static void SeedPoisonEffectStage(ModelBuilder builder, Guid poisonEffectId, int stageNumber, StaggeredEffectStage poisonEffectStage)
        {
            poisonEffectStage.StaggeredEffectId = poisonEffectId;
            poisonEffectStage.Stage = stageNumber;

            foreach (StaggeredEffectStageEffect stageEffect in poisonEffectStage.Effects)
            {
                SeedPoisonEffectStageEffect(builder, poisonEffectStage, stageEffect);
            }
            poisonEffectStage.Effects = new StaggeredEffectStageEffect[] { };
            
            builder.AddData(poisonEffectStage);
        }

        private static void SeedPoisonEffectStageEffect(ModelBuilder builder, StaggeredEffectStage poisonEffectStage, StaggeredEffectStageEffect stageEffect)
        {
            stageEffect.StaggeredEffectStageId = poisonEffectStage.Id;
            builder.AddData(stageEffect.GetType(), stageEffect);
        }

        protected abstract AlchemicalPoison GetAlchemicalPoison();
        protected abstract StaggeredEffect GetPoisonEffect();
        protected abstract SourcePage? GetSourcePage();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetailBlocks();
        protected abstract IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages();
    }
}
