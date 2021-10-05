using NpgsqlTypes;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class Source : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
