using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class HarrowMode : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class HarrowModeSearchConfigurator : SearchableEntityConfigurator<HarrowMode>
    {
        public override Expression<Func<HarrowMode, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
