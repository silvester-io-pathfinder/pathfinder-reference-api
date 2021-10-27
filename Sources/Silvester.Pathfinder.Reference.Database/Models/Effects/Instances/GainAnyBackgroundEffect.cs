using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyBackgroundEffect : BaseEffect
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyBackground(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new GainAnyBackgroundEffect { Id = id});
        }
    }
}
