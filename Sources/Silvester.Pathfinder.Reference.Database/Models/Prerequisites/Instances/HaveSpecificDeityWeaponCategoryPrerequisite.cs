using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificDeityWeaponCategoryPrerequisite : Prerequisite
    {
        public Guid WeaponCategoryId { get; set; }
        public WeaponCategory WeaponCategory { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificDeityWeaponCategory(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid weaponCategoryId)
        {
            return builder.Add(bindingId, new HaveSpecificDeityWeaponCategoryPrerequisite { Id = id, WeaponCategoryId = weaponCategoryId});
        }
    }
}
