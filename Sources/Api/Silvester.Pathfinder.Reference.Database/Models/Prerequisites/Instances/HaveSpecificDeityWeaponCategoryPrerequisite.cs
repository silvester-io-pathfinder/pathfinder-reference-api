using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificDeityWeaponCategoryPrerequisite : BasePrerequisite
    {
        public Guid WeaponCategoryId { get; set; }
        public WeaponCategory WeaponCategory { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificDeityWeaponCategory(this BooleanPrerequisiteBuilder builder, Guid id, Guid weaponCategoryId)
        {
            return builder.Add(new HaveSpecificDeityWeaponCategoryPrerequisite { Id = id, WeaponCategoryId = weaponCategoryId});
        }
    }
}
