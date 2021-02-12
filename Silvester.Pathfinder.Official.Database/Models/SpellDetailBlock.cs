using Silvester.Pathfinder.Official.Database;
using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class SpellDetailBlock : BaseEntity
    {
        public string Text { get; set; } = default!;

        public Spell Spell { get; set; } = default!;
        public Guid SpellId { get; set; }
    }
}
