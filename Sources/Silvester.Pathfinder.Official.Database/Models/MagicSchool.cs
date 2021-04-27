using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class MagicSchool : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Abbreviation { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Spell> Spells { get; set; } = new List<Spell>();
    }
}
