using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class Domain : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Deity> Deities { get; set; } = new List<Deity>();

        public ICollection<Mystery> Mysteries { get; set; } = new List<Mystery>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
