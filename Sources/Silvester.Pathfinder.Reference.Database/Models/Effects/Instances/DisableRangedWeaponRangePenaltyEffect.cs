using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class DisableRangedWeaponRangePenaltyEffect : BaseEffect
    {
        public RangeTier RangeTier { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder DisableRangedWeaponRangePenalty(this BooleanEffectBuilder builder, Guid id, RangeTier rangeTier)
        {
            return builder.Add(new DisableRangedWeaponRangePenaltyEffect { Id = id, RangeTier = rangeTier });
        }
    }
}
