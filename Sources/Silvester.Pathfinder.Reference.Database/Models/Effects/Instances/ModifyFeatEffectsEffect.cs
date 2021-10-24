using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ModifyFeatEffectsEffect : BaseEffect
    {
        public Guid FeatId { get; set; }
        public Feat Feat { get; set; } = default!;

        public Guid ModificationEffectId { get; set; }
        public BooleanEffect ModificationEffect { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ModifyFeatEffects(this BooleanEffectBuilder builder, Guid id, Guid modificationEffectId, Guid featId, Action<BooleanEffectBuilder> buildAction)
        {
            return builder.Add(new ModifyFeatEffectsEffect { Id = id, FeatId = featId, ModificationEffect = BooleanEffectBuilder.CreateAnd(modificationEffectId, buildAction).Build() });
        }
    }
}
