using Silvester.Pathfinder.Official.Database;
using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class SpellHeighteningDetailBlock : BaseEntity
    {
        public string Text { get; set; } = default!;

        public Guid SpellHeighteningId { get; set; }
        public SpellHeightening SpellHeightening { get; set; } = default!;
    }
}
