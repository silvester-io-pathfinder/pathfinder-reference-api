using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ModifyWeaponDamageEffect : BaseEffect
    {
        public int Modifier { get; set; }
        public ModifierType ModifierType { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ModifyWeaponDamage(this BooleanEffectBuilder builder, Guid id, ModifierType modifierType, int modifier)
        {
            return builder.Add(new ModifyWeaponDamageEffect { Id = id, ModifierType = modifierType, Modifier = modifier });
        }
    }
}
