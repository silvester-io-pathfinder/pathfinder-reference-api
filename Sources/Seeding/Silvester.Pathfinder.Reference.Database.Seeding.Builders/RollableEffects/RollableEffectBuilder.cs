using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Builders.RollableEffects
{
    public class RollableEffectBuilder
    {
        private RollableEffect RollableEffect { get; }

        public RollableEffectBuilder(Guid id, string? name = null)
        {
            RollableEffect = new RollableEffect { Id = id, Name = name };
        }

        public RollableEffectBuilder CriticalSuccess(string text)
        {
            RollableEffect.CriticalSuccess = text;
            return this;
        }

        public RollableEffectBuilder Success(string text)
        {
            RollableEffect.Success = text;
            return this;
        }

        public RollableEffectBuilder Failure(string text)
        {
            RollableEffect.Failure = text;
            return this;
        }

        public RollableEffectBuilder CriticalFailure(string text)
        {
            RollableEffect.CriticalFailure = text;
            return this;
        }

        public RollableEffect Build()
        {
            return RollableEffect;
        }
    }

    public static partial class SeedBuilderExtensions
    {
        public static ISeedBuilder AddRollableEffect<TOwner>(this ISeedBuilder self, TOwner owner, RollableEffect effect)
            where TOwner : BaseEntity
        {
            effect.OwnerId = owner.Id;
            self.AddData(effect);

            return self;
        }
    }
}
