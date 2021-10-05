using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions
{
    public class SearchConfigurator : SearchableEntityConfigurator<Condition>
    {
        public override Expression<Func<Condition, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
