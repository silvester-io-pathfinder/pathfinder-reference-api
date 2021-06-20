using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class ArmorCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Armor> Armors { get; set; } = new List<Armor>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
