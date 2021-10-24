using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificTraitEffect : BaseEffect
    {
        public Guid TraitId { get; set; }
        public Trait Trait { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificTrait(this BooleanEffectBuilder builder, Guid id, Guid traitId)
        {
            return builder.Add(new GainSpecificTraitEffect { Id = id, TraitId = traitId});
        }
    }
}
