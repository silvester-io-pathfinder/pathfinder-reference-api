using NpgsqlTypes;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Source : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class SourceSearchConfigurator : SearchableEntityConfigurator<Source>
    {
        public override Expression<Func<Source, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
