using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class AlchemicalElixir : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Usage { get; set; } = default!;
        
        public int ItemBonus { get; set; }

        public string? Benefit { get; set; }

        public string? Drawback { get; set; }

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid ActionId { get; set; }
        public Action Action { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public ICollection<AlchemicalElixirDetailBlock> Details { get; set; } = new List<AlchemicalElixirDetailBlock>();

        public ICollection<AlchemicalElixirPotencyBinding> Potencies { get; set; } = new List<AlchemicalElixirPotencyBinding>();

        public ICollection<AlchemicalElixirCraftingRequirement> CraftingRequirements { get; set; } = new List<AlchemicalElixirCraftingRequirement>();
    }

    public class AlchemicalElixirCraftingRequirement : BaseEntity
    {
        public string Text { get; set; } = default!;

        public Guid AlchemicalElixirId { get; set; }
        public AlchemicalElixir AlchemicalElixir { get; set; } = default!;
    }

    public class AlchemicalElixirDetailBlock : BaseEntity
    {
        public string Text { get; set; } = default!;

        public Guid AlchemicalElixirId { get; set; }
        public AlchemicalElixir AlchemicalElixir{ get; set; } = default!;
    }

    public class AlchemicalElixirPotencyBinding : BaseEntity
    {
        public int Level { get; set; }

        public int? Price { get; set; }

        public string Benefits { get; set; } = default!;

        public Guid AlchemicalElixirId { get; set; }
        public AlchemicalElixir AlchemicalElixir { get; set; } = default!;

        public Guid PotionPotencyId { get; set; }
        public PotionPotency PotionPotency { get; set; } = default!;

    }
}
