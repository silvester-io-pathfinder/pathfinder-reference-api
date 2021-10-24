using NpgsqlTypes;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public  class Proficiency : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int Bonus { get; set; }
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
