using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.HazardComplexities
{
    public class SearchConfigurator : SearchableEntityConfigurator<HazardComplexity>
    {
        public override Expression<Func<HazardComplexity, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
