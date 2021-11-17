using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificTraitFeatEffect : BaseEffect
    {
        public Guid TraitId { get; set; }
        public Trait Trait { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificTraitFeat(this BooleanEffectBuilder builder, Guid id, Guid traitId)
        {
            return builder.Add(new GainSpecificTraitFeatEffect { Id = id, TraitId = traitId });
        }
    }
}
