using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificFeatEffect : BaseEffect
    {
        public string? Restrictions { get; set; }

        public Guid FeatId { get; set; }
        public Feat Feat { get; set; } = default!;
    }
    
    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificFeat(this BooleanEffectBuilder builder, Guid id, Guid featId, string? restrictions = null)
        {
            return builder.Add(new GainSpecificFeatEffect { Id = id, FeatId = featId, Restrictions = restrictions });
        }
    }
}

