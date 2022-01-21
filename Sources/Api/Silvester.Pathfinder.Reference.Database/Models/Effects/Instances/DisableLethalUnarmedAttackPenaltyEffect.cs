using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class DisableLethalUnarmedAttackPenaltyEffect : BaseEffect
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder DisableLethalUnarmedAttackPenalty(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new DisableLethalUnarmedAttackPenaltyEffect { Id = id });
        }
    }
}
