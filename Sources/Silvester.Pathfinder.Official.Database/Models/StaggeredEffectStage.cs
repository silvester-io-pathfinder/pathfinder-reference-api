using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class StaggeredEffectStage : BaseEntity
    {
        public int Stage { get; set; }

        public string Duration { get; set; } = default!;

        public ICollection<StaggeredEffectStageEffect> Effects { get; set; } = new List<StaggeredEffectStageEffect>();

        public Guid StaggeredEffectId { get; set; }
        public StaggeredEffect StaggeredEffect { get; set; } = default!;
    }
}
