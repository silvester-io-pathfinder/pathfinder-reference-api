using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificMeleeWeaponEffect : BaseEffect
    {
        public Guid MeleeWeaponId { get; set; }
        public MeleeWeapon MeleeWeapon { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificMeleeWeapon(this BooleanEffectBuilder builder, Guid id, Guid meleeWeaponId)
        {
            return builder.Add(new GainSpecificMeleeWeaponEffect { Id = id, MeleeWeaponId = meleeWeaponId });
        }
    }
}

