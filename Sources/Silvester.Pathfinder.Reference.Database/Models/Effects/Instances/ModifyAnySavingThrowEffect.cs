using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ModifyAnySavingThrowEffect : BaseEffect
    {
        public RollResult InitialResult { get; set; }
        public RollResult Becomes { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ModifyAnySavingThrow(this BooleanEffectBuilder builder, Guid id, RollResult initialResult, RollResult becomes)
        {
            return builder.Add(new ModifyAnySavingThrowEffect { Id = id, InitialResult = initialResult, Becomes = becomes });
        }
    }
}
