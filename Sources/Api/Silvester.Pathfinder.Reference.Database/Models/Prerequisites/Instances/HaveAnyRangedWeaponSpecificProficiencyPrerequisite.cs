using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveAnyRangedWeaponSpecificProficiencyPrerequisite : BasePrerequisite
    {
        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveAnyRangedWeaponSpecificProficiency(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredProficiencyId)
        {
            return builder.Add(new HaveAnyRangedWeaponSpecificProficiencyPrerequisite { Id = id, RequiredProficiencyId = requiredProficiencyId });
        }
    }
}
