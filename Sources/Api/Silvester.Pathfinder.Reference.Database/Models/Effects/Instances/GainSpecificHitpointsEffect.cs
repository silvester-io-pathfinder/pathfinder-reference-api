using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificHitpointsEffect : BaseEffect
    {
        public ModifierType ModifierType { get; set; }
        public int Modifier { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificHitpoints(this BooleanEffectBuilder builder, Guid id, ModifierType modifierType, int modifier)
        {
            return builder.Add(new GainSpecificHitpointsEffect { Id = id, ModifierType = modifierType, Modifier = modifier });
        }
    }
}
