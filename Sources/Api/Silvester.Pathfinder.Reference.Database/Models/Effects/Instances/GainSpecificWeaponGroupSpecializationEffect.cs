using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificWeaponGroupSpecializationEffect : BaseEffect
    {
        public Guid WeaponGroupId { get; set; }
        public WeaponGroup WeaponGroup { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificWeaponGroupSpecialization(this BooleanEffectBuilder builder, Guid id, Guid weaponGroupId)
        {
            return builder.Add(new GainSpecificWeaponGroupSpecializationEffect { Id = id, WeaponGroupId = weaponGroupId});
        }
    }
}
