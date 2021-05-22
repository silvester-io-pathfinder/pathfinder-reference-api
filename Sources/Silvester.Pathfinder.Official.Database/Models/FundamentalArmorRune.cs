using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class FundamentalArmorRune : BaseEntity
    {
        public string Name { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
    }

    public class FundamentalArmorRuneVariant : BaseEntity
    {
        public string Name { get; set; } = default!;
        
        public int Price { get; set; }

        public int ItemLevel { get; set; }

        public string Benefits { get; set; } = default!;

        public string? CraftingRequirements { get; set; }

        public Guid RuneId { get; set; }
        public FundamentalArmorRune Rune { get; set; } = default!;
    }
}
