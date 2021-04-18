using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class HazardComponent : BaseEntity
    {
        public string Name { get; set; } = default!;
        public int HitPoints { get; set; }
        public int? Hardness { get; set; }
        public int? BrokenThreshold { get; set; }
        public string? Addendum { get; set; } 

        public Guid HazardId { get; set; }
        public Hazard Hazard { get; set; } = default!;
    }
}
