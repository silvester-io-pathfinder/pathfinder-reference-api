using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class ItemCurse : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Usage { get; set; } = default!;
        public int Level { get; set; }

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
    }
}
