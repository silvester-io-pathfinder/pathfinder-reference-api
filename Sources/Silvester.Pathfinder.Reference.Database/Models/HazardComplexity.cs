using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class HazardComplexity : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Hazard> Hazards { get; set; } = new List<Hazard>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
