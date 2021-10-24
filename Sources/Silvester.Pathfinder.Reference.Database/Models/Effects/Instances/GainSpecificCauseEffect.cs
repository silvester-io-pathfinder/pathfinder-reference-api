using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificCauseEffect : BaseEffect
    {
        public Guid CauseId { get; set; }
        public Cause Cause { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificCause(this BooleanEffectBuilder builder, Guid id, Guid causeId)
        {
            return builder.Add(new GainSpecificCauseEffect { Id = id, CauseId = causeId });
        }
    }
}
