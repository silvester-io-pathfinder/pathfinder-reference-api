using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class SpellType : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description{ get; set; } = default!;

        public ICollection<Spell> Spells { get; set; } = new List<Spell>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
