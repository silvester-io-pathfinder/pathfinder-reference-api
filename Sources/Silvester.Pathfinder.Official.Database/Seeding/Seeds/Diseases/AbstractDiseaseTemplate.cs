using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases
{
    public abstract class AbstractDiseaseTemplate
    {
        public void Seed(DiseaseSeeder seeder)
        {
            Disease disease = GetDisease(seeder);

            SourcePage? sourcePage = GetSourcePage(seeder);
            if(sourcePage != null)
            {
                seeder.Builder.AddData(sourcePage);
                disease.SourcePageId = sourcePage.Id;
            }

            DiseaseStage[] stages = GetDiseaseStages(seeder).ToArray();
            Guid currentGuid = disease.Id;
            for(int i = 0; i < stages.Length; i ++)
            {
                currentGuid = currentGuid.Increment();

                DiseaseStage stage = stages[i];
                stage.Id = currentGuid;
                stage.DiseaseId = disease.Id;
                stage.Stage = i + 1;

                foreach(DiseaseStageEffect effect in stage.Effects)
                {
                    Type type = effect.GetType();
                    currentGuid = currentGuid.Increment();
                    effect.Id = currentGuid;
                    effect.DiseaseStageId = stage.Id;

                    seeder.Builder.AddData(effect.GetType(), effect);
                }

                stage.Effects = new DiseaseStageEffect[] { };

                seeder.Builder.AddData(stage);
            }

            foreach (Trait trait in seeder.FilterTraits(GetTraits().ToArray()))
            {
                seeder.Builder.HasJoinData((disease, trait));
            }

            seeder.Builder.AddData(disease);
        }

        public abstract Disease GetDisease(DiseaseSeeder seeder);
        public abstract SourcePage? GetSourcePage(DiseaseSeeder seeder);
        public abstract IEnumerable<DiseaseStage> GetDiseaseStages(DiseaseSeeder seeder);
        public abstract IEnumerable<string> GetTraits();
    }
}
