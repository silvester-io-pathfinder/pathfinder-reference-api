using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificDamageResistanceEffect : BaseEffect
    {
        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificDamageResistance(this BooleanEffectBuilder builder, Guid id, Guid damageTypeId)
        {
            return builder.Add(new GainSpecificDamageResistanceEffect { Id = id, DamageTypeId = damageTypeId });
        }
    }
}
