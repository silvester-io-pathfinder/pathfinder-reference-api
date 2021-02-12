using Silvester.Pathfinder.Official.Database;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Item : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public int Level { get; set; }
    }
}
