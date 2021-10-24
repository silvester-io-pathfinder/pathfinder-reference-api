using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HazardComplexities
{
    public class SearchConfigurator : SearchableEntityConfigurator<HazardComplexity>
    {
        public override Expression<Func<HazardComplexity, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
