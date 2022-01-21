using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Builders.StaggeredEffects
{
    public class StaggeredEffectStageBuilder
    {
        private StaggeredEffectStage Stage { get; }

        public StaggeredEffectStageBuilder(Guid id, int stage, string duration)
        {
            Stage = new StaggeredEffectStage
            {
                Id = id,
                Stage = stage,
                Duration = duration
            };
        }

        public StaggeredEffectStageBuilder Effect(StaggeredEffectStageEffect  effect)
        {
            Stage.Effects.Add(effect);
            return this;
        }

        public StaggeredEffectStage Build()
        {
            return Stage;
        }
    }
}
