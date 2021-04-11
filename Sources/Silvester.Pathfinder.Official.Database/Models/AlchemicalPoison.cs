using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class AlchemicalPoison : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Usage { get; set; } = default!;
        
        public int ItemLevel { get; set; }

        public int Price { get; set; }

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid ActionId { get; set; }
        public Action Action { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid PoisonEffectId { get; set; }
        public PoisonEffect PoisonEffect { get; set; } = default!;

        public ICollection<AlchemicalPoisonDetailBlock> Details { get; set; } = new List<AlchemicalPoisonDetailBlock>();
    }

    public class AlchemicalPoisonDetailBlock : BaseEntity
    {
        public string Text { get; set; } = default!;

        public Guid AlchemicalPoisonId { get; set; }
        public AlchemicalPoison AlchemicalPoison { get; set; } = default!;
    }
}
