using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyBloodlineEffect : BaseEffect
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyBloodline(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new GainAnyBloodlineEffect { Id = id});
        }
    }
}
