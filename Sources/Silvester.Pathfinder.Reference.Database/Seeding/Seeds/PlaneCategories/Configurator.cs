using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlaneCategories
{
    public class SearchConfigurator : SearchableEntityConfigurator<PlaneCategory>
    {
        public override Expression<Func<PlaneCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
