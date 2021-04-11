using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class PoisonEffect : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Onset { get; set; } = default!;

        public int DifficultyCheck { get; set; }

        public string MaximumDuration { get; set; } = default!;
        
        public Guid SavingThrowStatId { get; set; }
        public SavingThrowStat SavingThrowStat { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public ICollection<PoisonEffectStage> Stages { get; set; } = new List<PoisonEffectStage>();
    }
}
