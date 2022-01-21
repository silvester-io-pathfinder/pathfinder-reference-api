using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificAbilityBoostEffect : BaseEffect
    {
        public Guid StatId { get; set; }
        public Stat Stat { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificAbilityBoost(this BooleanEffectBuilder builder, Guid id, Guid statId)
        {
            return builder.Add(new GainSpecificAbilityBoostEffect { Id = id, StatId = statId });
        }
    }
}
