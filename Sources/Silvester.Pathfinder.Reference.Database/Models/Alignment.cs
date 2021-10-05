using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class Alignment : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Deity> Deities { get; set; } = new List<Deity>();
        public ICollection<Deity> DeityFollowerAlignments { get; set; } = new List<Deity>();
        public ICollection<Plane> Planes { get; set; } = new List<Plane>();
        public ICollection<Artifact> Artifacts { get; set; } = new List<Artifact>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
