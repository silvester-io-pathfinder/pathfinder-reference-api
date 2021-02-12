using Silvester.Pathfinder.Official.Database;
using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class DeityFollowerAlignment : BaseEntity
    {
        public Guid DeityId { get; set; }
        public Deity Deity { get; set; } = default!;

        public Guid AlignmentId { get; set; }
        public Alignment Alignment { get; set; } = default!;
    }
}
