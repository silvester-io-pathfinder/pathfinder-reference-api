namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Bulk : BaseEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int LightWeight { get; set; }

        public int BulkWeight { get; set; }
    }
}
