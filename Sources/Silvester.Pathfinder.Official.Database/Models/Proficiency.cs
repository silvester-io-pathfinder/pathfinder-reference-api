namespace Silvester.Pathfinder.Official.Database.Models
{
    public  class Proficiency : BaseEntity
    {
        public string Name { get; set; } = default!;

        public int Bonus { get; set; }
    }
}
