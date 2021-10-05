using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.RaceSizes
{
    public class SearchConfigurator : SearchableEntityConfigurator<RaceSize>
    {
        public override Expression<Func<RaceSize, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
