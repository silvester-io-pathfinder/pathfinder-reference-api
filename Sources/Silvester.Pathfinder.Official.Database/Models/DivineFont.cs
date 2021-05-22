using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class DivineFont : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Deity> Deities { get; set; } = new List<Deity>();
    }
}
