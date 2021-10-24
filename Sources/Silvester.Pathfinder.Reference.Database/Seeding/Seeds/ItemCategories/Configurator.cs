using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories
{
    public class SearchConfigurator : SearchableEntityConfigurator<ItemCategory>
    {
        public override Expression<Func<ItemCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
