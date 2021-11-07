using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificUnarmedAttackEffect : BaseEffect
    {
        public UnarmedAttack UnarmedAttack { get; set; }

        public Guid WeaponGroupId { get; set; }
        public WeaponGroup WeaponGroup { get; set; } = default!;

        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;

        public string Damage { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificUnarmedAttack(this BooleanEffectBuilder builder, Guid id, UnarmedAttack unarmedAttack, Guid weaponGroupId, Guid damageTypeId, string damage)
        {
            return builder.Add(new GainSpecificUnarmedAttackEffect { Id = id, UnarmedAttack = unarmedAttack, WeaponGroupId = weaponGroupId, Damage = damage });
        }
    }
}
