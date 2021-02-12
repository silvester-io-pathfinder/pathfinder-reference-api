using Silvester.Pathfinder.Official.Database;
using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class FeatDetailsBlock : BaseEntity
    {
        public string Text { get; set; } = default!;

        public Feat Feat { get; set; } = default!;
        public Guid FeatId { get; set; }
    }
}
