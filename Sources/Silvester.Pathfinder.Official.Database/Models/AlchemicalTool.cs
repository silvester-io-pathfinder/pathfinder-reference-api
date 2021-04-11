using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public ICollection<Trait> Traits = new List<Trait>();

        public ICollection<AlchemicalToolDetailBlock> Details { get; set; } = new List<AlchemicalToolDetailBlock>();
    }

    public enum AlchemicalToolDetailBlockType
    {
        Text,
        Enumeration
    }

    public class AlchemicalToolPotencyBinding : BaseEntity
    {
        public int Level { get; set; }
        
        public int Price { get; set; }

        public string Benefits { get; set; } = default!;

        public Guid ToolId { get; set; }
        public AlchemicalTool Tool { get; set; } = default!;

        public Guid PotencyId { get; set; }
        public AlchemicalToolPotency Potency { get; set; } = default!;
    }

    public class AlchemicalToolPotency : BaseEntity
    {
        public string Name { get; set; } = default!;

        public Guid BindingId { get; set; }
        public AlchemicalToolPotencyBinding Binding { get; set; } = default!;
    }

    public class AlchemicalToolDetailBlock : BaseEntity
    {
        public string Text { get; set; } = default!;

        public AlchemicalToolDetailBlockType Type { get; set; }

        public Guid AlchemicalToolId { get; set; }
        public AlchemicalPoison AlchemicalTool { get; set; } = default!;
    }

}
