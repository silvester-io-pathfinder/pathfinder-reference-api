using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class ClassFeature : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public int Level { get; set; }

        public Class Class { get; set; } = default!;
        public Guid ClassId { get; set; }
    }
}
