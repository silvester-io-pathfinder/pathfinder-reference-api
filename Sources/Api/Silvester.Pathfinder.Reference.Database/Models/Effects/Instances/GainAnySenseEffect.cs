using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnySenseEffect : BaseEffect
    {
        public string? Range { get; set; }

        public Guid SenseAccuracyId { get; set; }
        public SenseAccuracy SenseAccuracy { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnySense(this BooleanEffectBuilder builder, Guid id, Guid senseAccuracyId, string? range)
        {
            return builder.Add(new GainAnySenseEffect { Id = id, Range = range, SenseAccuracyId = senseAccuracyId });
        }
    }
}