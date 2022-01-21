using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyAssuranceEffect : BaseEffect
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyAssurance(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new GainAnyAssuranceEffect { Id = id });
        }
    }
}
