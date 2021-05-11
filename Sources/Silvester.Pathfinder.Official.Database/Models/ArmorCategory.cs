using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class ArmorGroup : BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Armor> Armors { get; set; } = new List<Armor>();
    }
}
