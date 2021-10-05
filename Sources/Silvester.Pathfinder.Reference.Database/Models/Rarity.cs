using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class Rarity : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Race> Races { get; set; } = new List<Race>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
