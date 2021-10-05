using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class Potency : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int Order { get; set; }

        public ICollection<AlchemicalBombPotencyBinding> AlchemicalBombs { get; set; } = new List<AlchemicalBombPotencyBinding>();
        public ICollection<AlchemicalToolPotencyBinding> AlchemicalTools { get; set; } = new List<AlchemicalToolPotencyBinding>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
