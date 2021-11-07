using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificDamageResistanceEffect : BaseEffect
    {
        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;

        public ModifierInput ModifierInput { get; set; }
        public ModifierType ModifierType { get; set; }
        public int Modifier { get; set; }
        public int Minimum { get; set; }

        public string? Addendum { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificDamageResistance(this BooleanEffectBuilder builder, Guid id, Guid damageTypeId, ModifierInput modifierInput, ModifierType modifierType, int modifier, int minimum, string? addendum = null)
        {
            return builder.Add(new GainSpecificDamageResistanceEffect { Id = id, DamageTypeId = damageTypeId, ModifierInput = modifierInput, ModifierType = modifierType, Modifier = modifier, Minimum = minimum, Addendum = addendum});
        }
    }
}
