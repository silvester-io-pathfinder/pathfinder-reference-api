using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class DisableFeatPrerequisitesEffect : BaseEffect
    {
        public Guid FeatId { get; set; }
        public Feat Feat { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder DisableFeatPrerequisites(this BooleanEffectBuilder builder, Guid id, Guid featId)
        {
            return builder.Add(new DisableFeatPrerequisitesEffect { Id = id, FeatId = featId });
        }
    }
}

