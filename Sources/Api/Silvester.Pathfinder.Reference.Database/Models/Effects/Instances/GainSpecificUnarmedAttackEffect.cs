using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificUnarmedAttackEffect : BaseEffect
    {
        public Guid UnarmedWeaponId { get; set; }
        public UnarmedWeapon UnarmedWeapon { get; set; } = default!;

        public Guid WeaponGroupId { get; set; }
        public WeaponGroup WeaponGroup { get; set; } = default!;

        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;

        public string Damage { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificUnarmedAttack(this BooleanEffectBuilder builder, Guid id, Guid unarmedWeaponId, Guid weaponGroupId, Guid damageTypeId, string damage)
        {
            return builder.Add(new GainSpecificUnarmedAttackEffect { Id = id, UnarmedWeaponId = unarmedWeaponId, WeaponGroupId = weaponGroupId, Damage = damage, DamageTypeId = damageTypeId });
        }
    }
}
