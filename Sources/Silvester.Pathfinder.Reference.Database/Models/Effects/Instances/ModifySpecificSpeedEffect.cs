using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ModifySpecificSpeedEffect : BaseEffect
    {
        public int Modifier { get; set; }
        public ModifierType ModifierType { get; set; }
        public MovementMethod MovementMethod { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ModifySpecificSpeed(this BooleanEffectBuilder builder, Guid id, MovementMethod movementMethod, ModifierType modifierType, int modifier)
        {
            return builder.Add(new ModifySpecificSpeedEffect { Id = id, ModifierType = modifierType, Modifier = modifier, MovementMethod = movementMethod });
        }
    }
}
