using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class AncestrySize : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int Space { get; set; }

        public int HeightReach { get; set; }

        public int BreadthReach { get; set; }

        public ICollection<Ancestry> Ancestries { get; set; } = new List<Ancestry>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
