using NpgsqlTypes;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Bulk : BaseEntity
    {
        public string Name { get; set; } = default!;

        public int LightWeight { get; set; }

        public int BulkWeight { get; set; }
    }
}
