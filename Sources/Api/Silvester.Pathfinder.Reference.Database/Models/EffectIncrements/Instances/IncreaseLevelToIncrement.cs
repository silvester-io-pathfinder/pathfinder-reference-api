using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Instances
{
    public class IncreaseLevelToIncrement : EffectIncrement
    {
        public int Level { get; set; }
    }

    public static partial class EffectIncrementsBuilderExtensions
    {
        public static EffectIncrementsBuilder IncreaseLevelTo(this EffectIncrementsBuilder builder, Guid id, int level, EffectIncrementTrigger trigger)
        {
            return builder.Add(new IncreaseLevelToIncrement { Id = id, Level = level, Trigger = trigger});
        }
    }
}
