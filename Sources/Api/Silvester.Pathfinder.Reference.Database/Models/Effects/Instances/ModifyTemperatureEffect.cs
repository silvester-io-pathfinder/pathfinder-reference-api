using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ModifyTemperatureEffect : BaseEffect
    {
        public int Modifier { get; set; }
        public ModifierType ModifierType { get; set; }
        public Temperature Temperature { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ModifyTemperature(this BooleanEffectBuilder builder, Guid id, Temperature temperature, ModifierType modifierType, int modifier)
        {
            return builder.Add(new ModifyTemperatureEffect { Id = id, ModifierType = modifierType, Modifier = modifier, Temperature = temperature });
        }
    }
}
