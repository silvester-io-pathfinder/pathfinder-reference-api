using Silvester.Pathfinder.Official.Database;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class DeityCategory : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;
    }
}
