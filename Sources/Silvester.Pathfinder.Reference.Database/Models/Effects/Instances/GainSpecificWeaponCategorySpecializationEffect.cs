using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificWeaponCategorySpecializationEffect : BaseEffect
    {
        public Guid WeaponCategoryId { get; set; }
        public WeaponCategory WeaponCategory { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificWeaponCategorySpecialization(this BooleanEffectBuilder builder, Guid id, Guid weaponCategoryId)
        {
            return builder.Add(new GainSpecificWeaponCategorySpecializationEffect { Id = id, WeaponCategoryId = weaponCategoryId });
        }
    }
}
