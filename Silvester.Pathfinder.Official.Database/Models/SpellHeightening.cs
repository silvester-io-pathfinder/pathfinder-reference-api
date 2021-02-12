using Silvester.Pathfinder.Official.Database;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class SpellHeightening : BaseEntity
    {
        public int Level { get; set; }

        public string Description { get; set; } = default!;

        public ICollection<SpellHeighteningDetailBlock> Details { get; set; } = new List<SpellHeighteningDetailBlock>();

        public Guid SpellId { get; set; }
        public Spell Spell { get; set; } = default!;
    }
}
