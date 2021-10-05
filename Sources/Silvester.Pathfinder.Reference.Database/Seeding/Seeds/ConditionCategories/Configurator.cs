using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ConditionCategories
{
    public class SearchConfigurator : SearchableEntityConfigurator<ConditionCategory>
    {
        public override Expression<Func<ConditionCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
