using NpgsqlTypes;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class PlaneCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Plane> Planes { get; set; } = new List<Plane>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class PlaneCategorySearchConfigurator : SearchableEntityConfigurator<PlaneCategory>
    {
        public override Expression<Func<PlaneCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
