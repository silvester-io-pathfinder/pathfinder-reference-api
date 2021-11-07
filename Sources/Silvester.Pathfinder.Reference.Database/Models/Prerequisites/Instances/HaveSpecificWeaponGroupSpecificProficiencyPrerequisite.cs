using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificWeaponGroupSpecificProficiencyPrerequisite : BasePrerequisite
    {
        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;

        public Guid RequiredWeaponGroupId { get; set; }
        public WeaponGroup RequiredWeaponGroup { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificWeaponGroupSpecificProficiency(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredProficiencyId, Guid requiredWeaponGroupId)
        {
            return builder.Add(new HaveSpecificWeaponGroupSpecificProficiencyPrerequisite { Id = id, RequiredProficiencyId = requiredProficiencyId, RequiredWeaponGroupId = requiredWeaponGroupId });
        }
    }
}
