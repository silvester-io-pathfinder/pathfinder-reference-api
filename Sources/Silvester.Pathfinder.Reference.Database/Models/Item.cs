namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class Item : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public int Level { get; set; }
    }
}
