using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyHuntersEdgeEffect : BaseEffect
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyHuntersEdge(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new GainAnyHuntersEdgeEffect { Id = id });
        }
    }
}
