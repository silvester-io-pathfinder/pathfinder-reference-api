using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialItemCategories
{
    public class SearchConfigurator : SearchableEntityConfigurator<PreciousMaterialItemCategory>
    {
        public override Expression<Func<PreciousMaterialItemCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
