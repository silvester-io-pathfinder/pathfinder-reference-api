using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class InstinctAbility : BaseEntity, INamedEntity, ISearchableEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePager { get; set; } = default!;

        public Guid? TableId { get; set; }
        public Table? Table { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
