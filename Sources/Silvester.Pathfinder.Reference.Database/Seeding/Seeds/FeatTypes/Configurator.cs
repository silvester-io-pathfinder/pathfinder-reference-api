using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FeatTypes
{
    public class SearchConfigurator : SearchableEntityConfigurator<FeatType>
    {
        public override Expression<Func<FeatType, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
