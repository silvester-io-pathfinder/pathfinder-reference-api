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

            foreach (Trait trait in seeder.FilterTraits(GetTraits().ToArray()))
            {
                seeder.Builder.HasJoinData((poison, trait));
            }

            AlchemicalPoisonStage[] stages = GetAlchemicalPoisonStages(seeder).ToArray();
            Guid currentGuid = poison.Id;
            for (int i = 0; i < stages.Length; i++)
            {
                currentGuid = currentGuid.Increment();

                AlchemicalPoisonStage stage = stages[i];
                stage.Id = currentGuid;
                stage.AlchemicalPoisonId = poison.Id;
                stage.Stage = i + 1;

                foreach (AlchemicalPoisonStageEffect effect in stage.Effects)
                {
                    Type type = effect.GetType();
                    currentGuid = currentGuid.Increment();
                    effect.Id = currentGuid;
                    effect.AlchemicalPoisonStageId = stage.Id;

                    seeder.Builder.AddData(effect.GetType(), effect);
                }

                stage.Effects = new AlchemicalPoisonStageEffect[] { };

                seeder.Builder.AddData(stage);
            }

            seeder.Builder.AddData(poison);
        }

        protected abstract AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder);
        protected abstract SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder);
        protected abstract IEnumerable<string> GetTraits();
        protected abstract IEnumerable<AlchemicalPoisonDetailBlock> GetDetailBlocks();
        protected abstract IEnumerable<AlchemicalPoisonStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder);
    }
}
