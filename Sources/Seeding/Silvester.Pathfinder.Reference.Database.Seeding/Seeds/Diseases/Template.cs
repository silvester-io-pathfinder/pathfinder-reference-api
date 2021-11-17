using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Diseases
{
    public abstract class Template : EntityTemplate<Disease>
    {
        protected override Disease GetEntity(ISeedBuilder builder)
        {
            Disease disease = GetDisease();

            builder.AddSourcePage(disease, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(disease, GetTraits());

            DiseaseStage[] stages = GetDiseaseStages().ToArray();
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

                    builder.AddData(effect.GetType(), effect);
                }

                stage.Effects = new List<DiseaseStageEffect> { };

                builder.AddData(stage);
            }

            return disease;
        }

        public abstract Disease GetDisease();
        public abstract SourcePage? GetSourcePage();
        public abstract IEnumerable<DiseaseStage> GetDiseaseStages();
        public abstract IEnumerable<Guid> GetTraits();
    }
}
