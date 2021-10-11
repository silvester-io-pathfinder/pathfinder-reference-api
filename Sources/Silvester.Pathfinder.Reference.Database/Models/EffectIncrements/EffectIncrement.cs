using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Models.EffectIncrements
{
    public class EffectIncrement : BaseEntity
    {
        public Guid TriggerId { get; set; }
        public EffectIncrementTrigger Trigger { get; set; } = default!;

        public Guid EffectId { get; set; }
        public Effect Effect { get; set; } = default!;
    }
}
