using Silvester.Pathfinder.Official.Database;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Plane : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public Guid CategoryId { get; set; }
        public PlaneCategory Category { get; set; } = default!;

        public Guid AlignmentId { get; set; }
        public Alignment Alignment { get; set; } = default!;

        public ICollection<PlaneTrait> Traits { get; set; } = new List<PlaneTrait>();
    }
}
