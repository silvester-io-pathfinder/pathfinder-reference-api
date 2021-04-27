namespace Silvester.Pathfinder.Official.Database.Models
{
    public class ItemCategory : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public int PageNumber { get; set; }
    }
}
