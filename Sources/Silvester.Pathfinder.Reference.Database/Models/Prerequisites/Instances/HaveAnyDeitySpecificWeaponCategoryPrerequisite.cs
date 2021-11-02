using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveAnyDeitySpecificWeaponCategoryPrerequisite : BasePrerequisite
    {
        public Guid RequiredWeaponCategoryId { get; set; }
        public WeaponCategory RequiredWeaponCategory {get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveAnyDeitySpecificWeaponCategory(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredWeaponCategoryId)
        {
            return builder.Add(new HaveAnyDeitySpecificWeaponCategoryPrerequisite { Id = id, RequiredWeaponCategoryId = requiredWeaponCategoryId });
        }
    }
}
