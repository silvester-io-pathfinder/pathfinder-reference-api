using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class FeatType : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Feat> Feats { get; set; } = new List<Feat>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
