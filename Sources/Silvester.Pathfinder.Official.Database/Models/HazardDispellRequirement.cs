using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class HazardDispellRequirement : BaseEntity
    {
        public int Level { get; set; }

        public int CounteractDifficultyCheck { get; set; }

        public string Description { get; set; } = default!;

        public Guid HazardId { get; set; }
        public Hazard Hazard { get; set; } = default!;
    }
}
