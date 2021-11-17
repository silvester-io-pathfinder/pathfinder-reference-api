using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class HuntersEdge : BaseEntity, INamedEntity, ISearchableEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid? EffectId { get; set; }
        public BooleanEffect? Effect { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class HuntersEdgeSearchConfigurator : SearchableEntityConfigurator<HuntersEdge>
    {
        public override Expression<Func<HuntersEdge, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
