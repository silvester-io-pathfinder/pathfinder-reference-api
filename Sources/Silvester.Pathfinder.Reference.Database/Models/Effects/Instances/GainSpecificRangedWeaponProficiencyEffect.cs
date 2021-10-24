using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificRangedWeaponProficiencyEffect : BaseEffect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid RangedWeaponId { get; set; }
        public RangedWeapon RangedWeapon { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificRangedWeaponProficiency(this BooleanEffectBuilder builder, Guid id, Guid proficiencyId, Guid rangedWeaponId)
        {
            return builder.Add(new GainSpecificRangedWeaponProficiencyEffect { Id = id, ProficiencyId = proficiencyId, RangedWeaponId = rangedWeaponId });
        }
    }
}
