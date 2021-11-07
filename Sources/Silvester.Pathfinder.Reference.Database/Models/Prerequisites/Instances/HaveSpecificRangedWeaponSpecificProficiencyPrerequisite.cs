using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificRangedWeaponSpecificProficiencyPrerequisite : BasePrerequisite
    {
        public Guid RequiredRangedWeaponId { get; set; } 
        public RangedWeapon RequiredRangedWeapon { get; set; } = default!;

        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificRangedWeaponSpecificProficiency(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredProficiencyId, Guid requiredRangedWeaponId)
        {
            return builder.Add(new HaveSpecificRangedWeaponSpecificProficiencyPrerequisite { Id = id, RequiredProficiencyId = requiredProficiencyId, RequiredRangedWeaponId = requiredRangedWeaponId });
        }
    }
}
