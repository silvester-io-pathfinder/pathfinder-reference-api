using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificMeleeWeaponProficiencyEffect : BaseEffect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid MeleeWeaponId { get; set; }
        public MeleeWeapon MeleeWeapon { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificMeleeWeaponProficiency(this BooleanEffectBuilder builder, Guid id, Guid proficiencyId, Guid meleeWeaponId)
        {
            return builder.Add(new GainSpecificMeleeWeaponProficiencyEffect { Id = id, ProficiencyId = proficiencyId, MeleeWeaponId = meleeWeaponId });
        }
    }
}
