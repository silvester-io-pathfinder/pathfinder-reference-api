using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class HarrowCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Effects { get; set; } = default!;

        public string Description { get; set; } = default!;

        public Guid AffectedStatId { get; set; }
        public Stat AffectedStat { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
