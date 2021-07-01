using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Potencies
{
    public class SearchConfigurator : SearchableEntityConfigurator<Potency>
    {
        public override Expression<Func<Potency, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
