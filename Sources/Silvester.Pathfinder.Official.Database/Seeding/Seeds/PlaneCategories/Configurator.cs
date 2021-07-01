using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PlaneCategories
{
    public class SearchConfigurator : SearchableEntityConfigurator<PlaneCategory>
    {
        public override Expression<Func<PlaneCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
