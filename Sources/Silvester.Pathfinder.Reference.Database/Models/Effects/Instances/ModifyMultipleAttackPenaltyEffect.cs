using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ModifyMultipleAttackPenaltyEffect : BaseEffect
    {
        public ModifierType ModifierType { get; set; }
        public int Modifier { get; set; }

        public MultipleAttackPenalty MultipleAttackPenalty { get; set; }
        public bool IsWithAgileWeapon { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ModifyMultipleAttackPenalty(this BooleanEffectBuilder builder, Guid id, MultipleAttackPenalty multipleAttackPenalty, ModifierType modifierType, int modifier, bool isWithAgileWeapon)
        {
            return builder.Add(new ModifyMultipleAttackPenaltyEffect { Id = id, MultipleAttackPenalty = multipleAttackPenalty, ModifierType = modifierType, Modifier = modifier, IsWithAgileWeapon = isWithAgileWeapon });
        }
    }
}
