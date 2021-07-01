using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceSizes
{
    public class SearchConfigurator : SearchableEntityConfigurator<RaceSize>
    {
        public override Expression<Func<RaceSize, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
