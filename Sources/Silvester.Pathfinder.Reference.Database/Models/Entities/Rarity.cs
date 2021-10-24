using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Rarity : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Ancestry> Ancestries { get; set; } = new List<Ancestry>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
