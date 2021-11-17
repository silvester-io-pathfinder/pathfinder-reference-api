using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainFocusPoolPointEffect : BaseEffect
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainFocusPoolPoint(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new GainFocusPoolPointEffect { Id = id });
        }
    }
}
