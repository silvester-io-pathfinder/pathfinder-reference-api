using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class DruidicOrder : BaseEntity, INamedEntity, ISearchableEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid? EffectId { get; set; }
        public BooleanEffect? Effect { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class DruidicOrderSearchConfigurator : SearchableEntityConfigurator<DruidicOrder>
    {
        public override Expression<Func<DruidicOrder, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
