using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificMeleeWeaponSpecificProficiencyPrerequisite : BasePrerequisite
    {
        public Guid RequiredMeleeWeaponId { get; set; } 
        public MeleeWeapon RequiredMeleeWeapon { get; set; } = default!;

        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificMeleeWeaponSpecificProficiency(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredProficiencyId, Guid requiredMeleeWeaponId)
        {
            return builder.Add(new HaveSpecificMeleeWeaponSpecificProficiencyPrerequisite { Id = id, RequiredProficiencyId = requiredProficiencyId, RequiredMeleeWeaponId = requiredMeleeWeaponId });
        }
    }
}
