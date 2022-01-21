using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainInnovationArmorSpecializationEffect : BaseEffect
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainInnovationArmorSpecialization(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new GainInnovationArmorSpecializationEffect { Id = id });
        }
    }
}
