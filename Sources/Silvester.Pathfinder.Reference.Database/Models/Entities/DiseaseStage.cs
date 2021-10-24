using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class DiseaseStage : BaseEntity
    {
        public int Stage { get; set; }

        public TimeSpan? Duration { get; set; } = default!;

        public ICollection<DiseaseStageEffect> Effects { get; set; } = new List<DiseaseStageEffect>();

        public Guid DiseaseId { get; set; }
        public Disease Disease { get; set; } = default!;
    }
}
