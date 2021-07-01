using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories
{
    public class SearchConfigurator : SearchableEntityConfigurator<DeityCategory>
    {
        public override Expression<Func<DeityCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
