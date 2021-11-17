using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ImproveSpecificConditionAnySavingThrowEffect : BaseEffect
    {
        public string? Addendum { get; set; }

        public Guid ConditionId { get; set; }
        public Condition Condition { get; set; } = default!;

        public RollResult InitialResult { get; set; }
        public RollResult Becomes { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ImproveSpecificConditionAnySavingThrow(this BooleanEffectBuilder builder, Guid id, Guid conditionId, RollResult initialResult, RollResult becomes, string? addendum = null)
        {
            return builder.Add(new ImproveSpecificConditionAnySavingThrowEffect { Id = id, ConditionId = conditionId, InitialResult = initialResult, Becomes = becomes, Addendum = addendum });
        }
    }
}
