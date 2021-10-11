using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCategories
{
    public class SearchConfigurator : SearchableEntityConfigurator<HarrowCategory>
    {
        public override Expression<Func<HarrowCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Effects, e.Description };
        }
    }
}
