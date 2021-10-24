using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificWeaponCategoryProficiencyEffect : BaseEffect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid WeaponCategoryId { get; set; }
        public WeaponCategory WeaponCategory { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificWeaponCategoryProficiency(this BooleanEffectBuilder builder, Guid id, Guid proficiencyId, Guid weaponCategoryId)
        {
            return builder.Add(new GainSpecificWeaponCategoryProficiencyEffect { Id = id, ProficiencyId = proficiencyId , WeaponCategoryId = weaponCategoryId });
        }
    }
}
