using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ImproveAnySavingThrowEffect : BaseEffect
    {
        public RollResult InitialResult { get; set; }
        public RollResult Becomes { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ImproveAnySavingThrow(this BooleanEffectBuilder builder, Guid id, RollResult initialResult, RollResult becomes)
        {
            return builder.Add(new ImproveAnySavingThrowEffect { Id = id, InitialResult = initialResult, Becomes = becomes });
        }
    }
}
