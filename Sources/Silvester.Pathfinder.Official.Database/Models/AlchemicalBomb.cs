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

        public ICollection<AlchemicalBombDetailBlock> Details { get; set; } = new List<AlchemicalBombDetailBlock>();

        public Guid LesserId { get; set; }
        public AlchemicalBombPotencyBinding Lesser { get; set; } = default!;

        public Guid ModerateId { get; set; }
        public AlchemicalBombPotencyBinding Moderate { get; set; } = default!;

        public Guid GreaterId { get; set; }
        public AlchemicalBombPotencyBinding Greater { get; set; } = default!;

        public Guid MajorId { get; set; }
        public AlchemicalBombPotencyBinding Major { get; set; } = default!;
    }

    public class AlchemicalBombDetailBlock : BaseEntity
    {
        public string Text { get; set; } = default!;

        public Guid AlchemicalBombId { get; set; }
        public AlchemicalBomb AlchemicalBomb { get; set; } = default!;
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
