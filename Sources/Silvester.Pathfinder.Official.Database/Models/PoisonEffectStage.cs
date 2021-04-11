using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class PoisonEffectStage : BaseEntity
    {
        public int Stage { get; set; }

        public string Duration { get; set; } = default!;

        public ICollection<PoisonEffectStageEffect> Effects { get; set; } = new List<PoisonEffectStageEffect>();

        public Guid PoisonEffectId { get; set; }
        public PoisonEffect PoisonEffect { get; set; } = default!;
    }
}
