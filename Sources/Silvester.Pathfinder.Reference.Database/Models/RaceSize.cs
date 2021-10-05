using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class RaceSize : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int Space { get; set; }

        public int HeightReach { get; set; }

        public int BreadthReach { get; set; }

        public ICollection<Race> Races { get; set; } = new List<Race>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
