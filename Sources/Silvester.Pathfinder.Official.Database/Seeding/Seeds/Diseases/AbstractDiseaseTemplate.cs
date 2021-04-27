using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases
{
    public abstract class AbstractDiseaseTemplate : EntityTemplate<Disease>
    {
        protected override Disease GetEntity(ModelBuilder builder)
        {
            Disease disease = GetDisease();

            SourcePage? sourcePage = GetSourcePage();
            if(sourcePage != null)
            {
                builder.AddData(sourcePage);
                disease.SourcePageId = sourcePage.Id;
            }

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

                stage.Effects = new DiseaseStageEffect[] { };

                builder.AddData(stage);
            }

            foreach (Guid traitId in GetTraits())
            {
                builder.HasJoinData<Trait, Disease>((traitId, disease.Id));
            }

            return disease;
        }

        public abstract Disease GetDisease();
        public abstract SourcePage? GetSourcePage();
        public abstract IEnumerable<DiseaseStage> GetDiseaseStages();
        public abstract IEnumerable<Guid> GetTraits();
    }
}
