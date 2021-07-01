using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Planes
{
    public class SearchConfigurator : SearchableEntityConfigurator<Plane>
    {
        public override Expression<Func<Plane, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
