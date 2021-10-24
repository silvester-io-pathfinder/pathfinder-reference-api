using NpgsqlTypes;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Source : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
