using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainCurrentWeaponSpecializationEffect : BaseEffect
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainCurrentWeaponSpecialization(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new GainCurrentWeaponSpecializationEffect { Id = id });
        }
    }
}
