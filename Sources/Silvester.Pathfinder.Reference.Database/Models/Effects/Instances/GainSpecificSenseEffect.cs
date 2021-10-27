using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificSenseEffect : BaseEffect
    {
        public string? Range { get; set; }

        public Guid SenseId { get; set; }
        public Sense Sense { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificSense(this BooleanEffectBuilder builder, Guid id, Guid senseId, string? range = null)
        {
            return builder.Add(new GainSpecificSenseEffect { Id = id, SenseId = senseId, Range = range });
        }
    }
}
