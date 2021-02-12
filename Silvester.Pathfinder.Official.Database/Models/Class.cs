using Silvester.Pathfinder.Official.Database;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Class : BaseEntity
    {
        public string Name { get; set; } = default!;

        public int BaseHealth { get; set; }
    }
}
