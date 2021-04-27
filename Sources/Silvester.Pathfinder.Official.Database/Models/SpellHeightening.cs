using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class SpellHeightening : BaseEntity
    {
        public int Level { get; set; }

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public Guid SpellId { get; set; }
        public Spell Spell { get; set; } = default!;
    }
}
