using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ImproveSpecificSavingThrowEffect : BaseEffect
    {
        public Guid SavingThrowStatId { get; set; }
        public SavingThrowStat SavingThrowStat { get; set; } = default!;

        public RollResult InitialResult { get; set; }
        public RollResult Becomes { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ImproveSpecificSavingThrow(this BooleanEffectBuilder builder, Guid id, Guid savingThrowStatId, RollResult initialResult, RollResult becomes)
        {
            return builder.Add(new ImproveSpecificSavingThrowEffect { Id = id, SavingThrowStatId = savingThrowStatId, InitialResult = initialResult, Becomes = becomes });
        }
    }

}
