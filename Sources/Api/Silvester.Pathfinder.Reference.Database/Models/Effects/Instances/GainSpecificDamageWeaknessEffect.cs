using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificDamageWeaknessEffect : BaseEffect
    {
        public Guid DamageTypeId { get; set; }
        public DamageType DamageType  { get; set; } = default!;

        public ModifierType ModifierType { get; set; }
        public int Modifier { get; set; }
        public int Minimum { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificDamageWeakness(this BooleanEffectBuilder builder, Guid id, Guid damageTypeId, ModifierType modifierType, int modifier, int minimum)
        {
            return builder.Add(new GainSpecificDamageWeaknessEffect { Id = id, DamageTypeId = damageTypeId, ModifierType = modifierType, Modifier = modifier, Minimum = minimum });
        }
    }
}
