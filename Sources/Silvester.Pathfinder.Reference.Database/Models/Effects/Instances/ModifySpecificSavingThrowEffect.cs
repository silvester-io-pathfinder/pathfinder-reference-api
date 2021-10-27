using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ModifySpecificSavingThrowEffect : BaseEffect
    {
        public Guid SavingThrowStatId { get; set; }
        public SavingThrowStat SavingThrowStat { get; set; } = default!;

        public RollResult InitialResult { get; set; }
        public RollResult Becomes { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ModifySpecificSavingThrow(this BooleanEffectBuilder builder, Guid id, Guid savingThrowStatId, RollResult initialResult, RollResult becomes)
        {
            return builder.Add(new ModifySpecificSavingThrowEffect { Id = id, SavingThrowStatId = savingThrowStatId, InitialResult = initialResult, Becomes = becomes });
        }
    }

}
