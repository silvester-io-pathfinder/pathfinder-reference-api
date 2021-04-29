﻿using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class StaggeredEffect : BaseEntity
    {
        public string Onset { get; set; } = default!;

        public int DifficultyCheck { get; set; }

        public string MaximumDuration { get; set; } = default!;
        
        public Guid SavingThrowStatId { get; set; }
        public SavingThrowStat SavingThrowStat { get; set; } = default!;

        public ICollection<StaggeredEffectStage> Stages { get; set; } = new List<StaggeredEffectStage>();
    }
}