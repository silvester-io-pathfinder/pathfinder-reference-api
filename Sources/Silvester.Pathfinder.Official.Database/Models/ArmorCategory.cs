using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class ArmorCategory : BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Armor> Armors { get; set; } = new List<Armor>();
    }
}
