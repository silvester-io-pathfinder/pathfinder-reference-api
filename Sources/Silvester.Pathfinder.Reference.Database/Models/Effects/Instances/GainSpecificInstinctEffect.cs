using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificInstinctEffect : BaseEffect
    {
        public Guid InstinctId { get; set; }
        public Instinct Instinct { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificInstinct(this BooleanEffectBuilder builder, Guid id, Guid instinctId)
        {
            return builder.Add(new GainSpecificInstinctEffect { Id = id, InstinctId = instinctId });
        }
    }
}
