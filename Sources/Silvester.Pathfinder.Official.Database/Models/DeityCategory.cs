using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class DeityCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Deity> Deities { get; set; } = new List<Deity>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
