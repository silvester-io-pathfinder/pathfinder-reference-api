using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class SpellTrigger : BaseEntity
    {
        public string Text { get; set; } = default!;

        public Guid SpellId { get; set; }
        public Spell Spell { get; set; } = default!;
    }
}
