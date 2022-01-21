using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Builders.RollableEffects
{
    public class RollableEffectCollectionBuilder
    {
        private IList<RollableEffect> RollableEffects { get; }

        public RollableEffectCollectionBuilder()
        {
            RollableEffects = new List<RollableEffect>();
        }

        public RollableEffectCollectionBuilder Add(Guid id, string name, Action<RollableEffectBuilder> buildAction)
        {
            RollableEffectBuilder builder = new RollableEffectBuilder(id, name);
            buildAction.Invoke(builder);
            RollableEffects.Add(builder.Build());

            return this;
        }

        public IList<RollableEffect> Build()
        {
            return RollableEffects;
        }
    }

    public static partial class SeedBuilderExtensions
    {
        public static ISeedBuilder AddRollableEffects<TOwner>(this ISeedBuilder self, TOwner owner, Action<RollableEffectCollectionBuilder> buildAction)
            where TOwner : BaseEntity
        {
            RollableEffectCollectionBuilder builder = new RollableEffectCollectionBuilder();
            buildAction.Invoke(builder);

            return self.AddRollableEffects(owner, builder.Build());
        }

        public static ISeedBuilder AddRollableEffects<TOwner>(this ISeedBuilder self, TOwner owner, IEnumerable<RollableEffect> effects)
            where TOwner : BaseEntity
        {
            foreach (RollableEffect effect in effects)
            {
                self.AddRollableEffect(owner, effect);
            }

            return self;
        }
    }
}
