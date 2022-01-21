using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Builders.StaggeredEffects
{
    public class StaggeredEffectCollectionBuilder
    {
        private IList<StaggeredEffect> StaggeredEffects { get; }
        private Guid OwnerId { get; }

        public StaggeredEffectCollectionBuilder(Guid ownerId)
        {
            StaggeredEffects = new List<StaggeredEffect>();
            OwnerId = ownerId;
        }

        public StaggeredEffectCollectionBuilder Add(Guid id, string name, string onset, Guid savingThrowStatId, string maximumDuration, Action<StaggeredEffectBuilder> buildAction)
        {
            StaggeredEffectBuilder builder = new StaggeredEffectBuilder(id, OwnerId, name, onset, savingThrowStatId, maximumDuration);
            buildAction.Invoke(builder);
            StaggeredEffects.Add(builder.Build());

            return this;
        }

        public IList<StaggeredEffect> Build()
        {
            return StaggeredEffects;
        }
    }

    public static partial class SeedBuilderExtensions
    {
        public static ISeedBuilder AddStaggeredEffects<TOwner>(this ISeedBuilder self, TOwner owner, Action<StaggeredEffectCollectionBuilder> buildAction)
           where TOwner : BaseEntity
        {
            StaggeredEffectCollectionBuilder builder = new StaggeredEffectCollectionBuilder(owner.Id);
            buildAction.Invoke(builder);
            foreach (StaggeredEffect effect in builder.Build())
            {
                self.AddStaggeredEffect(owner, effect);
            }

            return self;
        }
    }
}
