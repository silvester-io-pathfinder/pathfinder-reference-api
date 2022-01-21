using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificSpeedEffect : BaseEffect
    {
        public string? Addendum { get; set; }
        public int Speed { get; set; }
        public MovementMethod MovementMethod { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificSpeed(this BooleanEffectBuilder builder, Guid id, MovementMethod movementMethod, int speed, string? addendum = null)
        {
            return builder.Add(new GainSpecificSpeedEffect { Id = id, MovementMethod = movementMethod, Speed = speed, Addendum = addendum });
        }
    }
}
