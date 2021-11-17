using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ProhibitSpecificFeatEffect : BaseEffect
    {
        public Guid ProhibitedFeatId { get; set; }
        public Feat ProhibitedFeat { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ProhibitSpecificFeat(this BooleanEffectBuilder builder, Guid id, Guid prohibitedFeatId)
        {
            return builder.Add(new ProhibitSpecificFeatEffect { Id = id, ProhibitedFeatId = prohibitedFeatId });
        }
    }
}
