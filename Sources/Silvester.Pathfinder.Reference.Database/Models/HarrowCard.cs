using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class HarrowCard : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!; 

        public Guid AlignmentId { get; set; }
        public Alignment Alignment { get; set; } = default!;

        public Guid HarrowCategoryId { get; set; }
        public HarrowCategory HarrowCategory { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
