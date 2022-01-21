using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.EffectIncrements
{
    public class EffectIncrement : BaseEntity
    {
        public Guid TriggerId { get; set; }
        public EffectIncrementTrigger Trigger { get; set; } = default!;

        public Guid EffectId { get; set; }
        public BaseEffect Effect { get; set; } = default!;
    }
}
