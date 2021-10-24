using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Planes
{
    public class SearchConfigurator : SearchableEntityConfigurator<Plane>
    {
        public override Expression<Func<Plane, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
