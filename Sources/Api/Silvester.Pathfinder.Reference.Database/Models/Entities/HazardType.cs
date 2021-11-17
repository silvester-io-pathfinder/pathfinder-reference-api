using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class HazardType : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<Hazard> Hazards { get; set; } = new List<Hazard>();
        
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class HazardTypeSearchConfigurator : SearchableEntityConfigurator<HazardType>
    {
        public override Expression<Func<HazardType, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
