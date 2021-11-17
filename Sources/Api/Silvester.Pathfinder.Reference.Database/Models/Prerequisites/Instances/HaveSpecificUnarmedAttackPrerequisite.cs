using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificUnarmedAttackPrerequisite : BasePrerequisite
    {
        public Guid RequiredUnarmedWeaponId { get; set; } = default!;
        public UnarmedWeapon RequiredUnarmedWeapon { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificUnarmedAttack(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredUnarmedWeaponId)
        {
            return builder.Add(new HaveSpecificUnarmedAttackPrerequisite { Id = id, RequiredUnarmedWeaponId = requiredUnarmedWeaponId });
        }
    }
}
