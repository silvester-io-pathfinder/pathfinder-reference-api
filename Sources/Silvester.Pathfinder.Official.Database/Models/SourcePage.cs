using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class SourcePage : BaseEntity
    {
        public Guid OwnerId { get; set; }

        public int Page { get; set; }

        public Guid SourceId { get; set; }
        public Source Source { get; set; } = default!;
    }
}
