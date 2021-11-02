using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificWeaponGroupProficiencyEffect : BaseEffect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid WeaponGroupId { get; set; }
        public WeaponGroup WeaponGroup { get; set; } = default!;

        public Guid WeaponCategoryId{ get; set; }
        public WeaponCategory WeaponCategory { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificWeaponGroupProficiency(this BooleanEffectBuilder builder, Guid id, Guid proficiencyId, Guid weaponGroupId, Guid weaponCategoryId)
        {
            return builder.Add(new GainSpecificWeaponGroupProficiencyEffect { Id = id, ProficiencyId = proficiencyId, WeaponGroupId = weaponGroupId, WeaponCategoryId = weaponCategoryId});
        }
    }
}