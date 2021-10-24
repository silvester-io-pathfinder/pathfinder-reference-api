using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Instances
{
    public class IncreaseAmountToIncrement : EffectIncrement
    {
        public int Amount { get; set; }
    }

    public static partial class EffectIncrementsBuilderExtensions
    {
        public static EffectIncrementsBuilder IncreaseAmountTo(this EffectIncrementsBuilder builder, Guid id, int amount, EffectIncrementTrigger trigger)
        {
            return builder.Add(new IncreaseAmountToIncrement { Id = id, Amount = amount, Trigger = trigger});
        }
    }
}
