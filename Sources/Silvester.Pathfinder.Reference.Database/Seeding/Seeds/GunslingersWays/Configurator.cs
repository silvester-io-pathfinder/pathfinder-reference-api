using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.GunslingersWays
{
    public class SearchConfigurator : SearchableEntityConfigurator<GunslingersWay>
    {
        public override Expression<Func<GunslingersWay, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
