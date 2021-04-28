using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Potency : BaseEntity
    {
        public string Name { get; set; } = default!;

        public int Order { get; set; }

        public ICollection<AlchemicalBombPotencyBinding> AlchemicalBombs { get; set; } = new List<AlchemicalBombPotencyBinding>();
        public ICollection<AlchemicalToolPotencyBinding> AlchemicalTools { get; set; } = new List<AlchemicalToolPotencyBinding>();
    }
}
