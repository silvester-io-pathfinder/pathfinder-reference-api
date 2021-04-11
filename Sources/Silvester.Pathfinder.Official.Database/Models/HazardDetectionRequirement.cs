using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class HazardDetectionRequirement : BaseEntity
    {
        public int DifficultyCheck { get; set; }

        public string? Addendum { get; set; }

        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;

        public Guid HazardId { get; set; }
        public Hazard Hazard { get; set; } = default!;
    }
}
