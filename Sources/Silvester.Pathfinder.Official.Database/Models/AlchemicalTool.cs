using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class AlchemicalTool : BaseEntity
    {
        public string Name { get; set; } = default!;

        public int? Price { get; set; }

        public int ItemLevel { get; set; }

        public string Usage { get; set; } = default!;

        public string? ActivationAddendum { get; set; }

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;
        
        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid ActionId { get; set; }
        public Action Action { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
    
        public ICollection<AlchemicalToolPotencyBinding> Potencies { get; set; } = new List<AlchemicalToolPotencyBinding>();
    }

    public class AlchemicalToolPotencyBinding : BaseEntity
    {
        public int Level { get; set; }
        
        public int Price { get; set; }

        public string Benefits { get; set; } = default!;

        public Guid ToolId { get; set; }
        public AlchemicalTool Tool { get; set; } = default!;

        public Guid PotencyId { get; set; }
        public Potency Potency { get; set; } = default!;
    }
}
