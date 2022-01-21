using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Builders.StaggeredEffects
{
    public interface IStaggeredEffectBuilder
    {
        StaggeredEffectBuilder Addendum(string addendum);
        StaggeredEffect Build();
        StaggeredEffectBuilder DifficultyCheck(int difficultyCheck);
        StaggeredEffectBuilder Level(int level);
        StaggeredEffectBuilder Stage(Guid id, string duration, Action<StaggeredEffectStageBuilder> buildAction);
        StaggeredEffectBuilder Traits(Action<TraitBindingBuilder<StaggeredEffectTraitBinding, StaggeredEffect>> buildAction);
    }

    public class StaggeredEffectBuilder : IStaggeredEffectBuilder
    {
        private StaggeredEffect StaggeredEffect { get; }

        public StaggeredEffectBuilder(Guid id, Guid ownerId, string name, string onset, Guid savingThrowStatId, string maximumDuration)
        {
            StaggeredEffect = new StaggeredEffect
            {
                Id = id,
                Name = name,
                OwnerId = ownerId,
                Onset = onset,
                SavingThrowStatId = savingThrowStatId,
                MaximumDuration = maximumDuration
            };
        }

        public StaggeredEffectBuilder Level(int level)
        {
            StaggeredEffect.Level = level;
            return this;
        }

        public StaggeredEffectBuilder DifficultyCheck(int difficultyCheck)
        {
            StaggeredEffect.DifficultyCheck = difficultyCheck;
            return this;
        }

        public StaggeredEffectBuilder Addendum(string addendum)
        {
            StaggeredEffect.Addendum = addendum;
            return this;
        }

        public StaggeredEffectBuilder Stage(Guid id, string duration, Action<StaggeredEffectStageBuilder> buildAction)
        {
            StaggeredEffectStageBuilder builder = new StaggeredEffectStageBuilder(id, StaggeredEffect.Stages.Count + 1, duration);
            buildAction.Invoke(builder);
            StaggeredEffect.Stages.Add(builder.Build());
            return this;
        }

        public StaggeredEffectBuilder Traits(Action<TraitBindingBuilder<StaggeredEffectTraitBinding, StaggeredEffect>> buildAction)
        {
            TraitBindingBuilder<StaggeredEffectTraitBinding, StaggeredEffect> builder = new(StaggeredEffect.Id);
            buildAction.Invoke(builder);
            StaggeredEffect.Traits = builder.Build();
            return this;
        }

        public StaggeredEffect Build()
        {
            return StaggeredEffect;
        }
    }

    public static partial class SeedBuilderExtensions
    {
        public static ISeedBuilder AddStaggeredEffect<TOwner>(this ISeedBuilder self, TOwner owner, StaggeredEffect? effect)
            where TOwner : BaseEntity
        {
            if(effect == null)
            {
                return self;
            }

            effect.OwnerId = owner.Id;
            StaggeredEffectStage[] stages = effect.Stages.ToArray();
            for (int i = 0; i < stages.Length; i++)
            {
                StaggeredEffectStage stage = stages[i];
                stage.StaggeredEffectId = effect.Id;
                stage.Stage = i + 1;

                foreach (StaggeredEffectStageEffect stageEffect in stage.Effects)
                {
                    stageEffect.StaggeredEffectStageId = stage.Id;
                    self.AddData(stageEffect.GetType(), stageEffect);
                }

                stage.Effects = new List<StaggeredEffectStageEffect> { };
                self.AddData(stage);
            }
            effect.Stages = new List<StaggeredEffectStage>();

            foreach (StaggeredEffectTraitBinding binding in effect.Traits)
            {
                binding.OwnerId = effect.Id;
                self.AddData(binding.GetType(), binding);
            }
            effect.Traits = new List<StaggeredEffectTraitBinding>();

            self.AddData(effect);

            return self;
        }
    }
}
