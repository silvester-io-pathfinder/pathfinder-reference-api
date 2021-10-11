using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.LoresCategories
{
    public class SearchConfigurator : SearchableEntityConfigurator<LoreCategory>
    {
        public override Expression<Func<LoreCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
