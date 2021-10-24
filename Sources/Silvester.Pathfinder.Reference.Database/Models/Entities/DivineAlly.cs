using NpgsqlTypes;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class DivineAlly : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public string Description { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
