using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificTraitSpellEffect : BaseEffect
    {
        public Guid TraitId { get; set; }
        public Trait Trait { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificTraitSpell(this BooleanEffectBuilder builder, Guid id, Guid traitId)
        {
            return builder.Add(new GainSpecificTraitSpellEffect { Id = id, TraitId = traitId });
        }
    }
}
