using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class SpellRequirement : BaseEntity
    {
        public string Text { get; set; } = default!;

        public Spell Spell { get; set; } = default!;
        public Guid SpellId { get; set; }
    }
}
