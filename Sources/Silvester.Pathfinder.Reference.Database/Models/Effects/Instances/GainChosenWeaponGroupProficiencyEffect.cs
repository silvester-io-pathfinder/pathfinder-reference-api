using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainChosenWeaponGroupProficiencyEffect : BaseEffect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid WeaponCategoryId { get; set; }
        public WeaponCategory WeaponCategory { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainChosenWeaponGroupProficiency(this BooleanEffectBuilder builder, Guid id, Guid proficiencyId, Guid weaponCategoryId)
        {
            return builder.Add(new GainChosenWeaponGroupProficiencyEffect { Id = id, ProficiencyId = proficiencyId , WeaponCategoryId = weaponCategoryId });
        }
    }
}

