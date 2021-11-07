using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class EffectArea : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<DraconicExemplar> DraconicExemplars { get; set; } = new List<DraconicExemplar>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
