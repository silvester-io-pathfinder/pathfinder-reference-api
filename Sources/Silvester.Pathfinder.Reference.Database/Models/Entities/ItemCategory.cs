using NpgsqlTypes;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ItemCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public int PageNumber { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
