using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class AlchemicalBomb : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Usage { get; set; } = default!;
        
        public int ItemBonus { get; set; }

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid ActionId { get; set; }
        public Action Action { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<AlchemicalBombPotencyBinding> Potencies { get; set; } = new List<AlchemicalBombPotencyBinding>();
    }

    public class AlchemicalBombPotencyBinding : BaseEntity
    {
        public int Level { get; set; }

        public int Price { get; set; }

        public string Benefits { get; set; } = default!;

        public Guid AlchemicalBombId { get; set; }
        public AlchemicalBomb AlchemicalBomb { get; set; } = default!;

        public Guid PotionPotencyId { get; set; }
        public PotionPotency PotionPotency { get; set; } = default!;
    }
}
