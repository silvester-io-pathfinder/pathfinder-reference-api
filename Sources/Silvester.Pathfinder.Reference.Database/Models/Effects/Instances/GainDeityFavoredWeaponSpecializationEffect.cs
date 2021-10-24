using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    /// <summary>
    /// When you critically succeed at an attack roll using your deity's favored weapon, you apply the weapon's critical specialization effect.
    /// </summary>
    public class GainDeityFavoredWeaponSpecializationEffect : BaseEffect
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainDeityFavoredWeaponSpecialization(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new GainDeityFavoredWeaponSpecializationEffect { Id = id });
        }
    }
}
