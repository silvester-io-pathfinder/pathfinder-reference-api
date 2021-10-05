using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DeityCategories
{
    public class SearchConfigurator : SearchableEntityConfigurator<DeityCategory>
    {
        public override Expression<Func<DeityCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
