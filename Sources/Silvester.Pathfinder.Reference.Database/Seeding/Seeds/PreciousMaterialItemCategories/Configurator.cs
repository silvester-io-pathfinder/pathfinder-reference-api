using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialItemCategories
{
    public class SearchConfigurator : SearchableEntityConfigurator<PreciousMaterialItemCategory>
    {
        public override Expression<Func<PreciousMaterialItemCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
