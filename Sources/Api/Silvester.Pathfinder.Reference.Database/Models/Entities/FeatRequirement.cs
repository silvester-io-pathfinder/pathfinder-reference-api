using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class FeatRequirement : BaseEntity
    {
        public string Text { get; set; } = default!;

        public Feat Feat { get; set; } = default!;
        public Guid FeatId { get; set; }
    }
}
