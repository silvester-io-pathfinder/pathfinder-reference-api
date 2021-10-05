using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class Heritage : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;

        public ICollection<Race> Races { get; set; } = new List<Race>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
