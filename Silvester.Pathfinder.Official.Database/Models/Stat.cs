using Silvester.Pathfinder.Official.Database;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Stat : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Abbreviation { get; set; } = default!;
    }
}
