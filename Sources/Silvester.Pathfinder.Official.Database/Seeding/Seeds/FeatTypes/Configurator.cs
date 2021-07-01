using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.FeatTypes
{
    public class SearchConfigurator : SearchableEntityConfigurator<FeatType>
    {
        public override Expression<Func<FeatType, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
