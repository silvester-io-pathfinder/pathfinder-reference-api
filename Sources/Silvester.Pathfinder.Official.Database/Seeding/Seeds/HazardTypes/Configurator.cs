using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.HazardTypes
{
    public class SearchConfigurator : SearchableEntityConfigurator<HazardType>
    {
        public override Expression<Func<HazardType, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
