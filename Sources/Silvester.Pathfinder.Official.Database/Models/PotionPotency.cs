using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class PotionPotency : BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<AlchemicalBombPotencyBinding> AlchemicalBombs { get; set; } = new List<AlchemicalBombPotencyBinding>();
    }
}
