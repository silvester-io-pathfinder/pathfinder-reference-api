using NpgsqlTypes;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class AttackType : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
