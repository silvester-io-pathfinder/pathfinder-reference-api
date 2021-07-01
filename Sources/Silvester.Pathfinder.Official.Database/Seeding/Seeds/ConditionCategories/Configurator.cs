using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ConditionCategories
{
    public class SearchConfigurator : SearchableEntityConfigurator<ConditionCategory>
    {
        public override Expression<Func<ConditionCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
