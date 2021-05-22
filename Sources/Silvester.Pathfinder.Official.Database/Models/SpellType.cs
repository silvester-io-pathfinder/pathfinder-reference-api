using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class SpellType : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description{ get; set; } = default!;

        public ICollection<Spell> Spells { get; set; } = new List<Spell>();
    }
}
