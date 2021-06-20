using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class PlaneCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Plane> Planes { get; set; } = new List<Plane>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
