using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HybridStudies
{
    public class SearchConfigurator : SearchableEntityConfigurator<HybridStudy>
    {
        public override Expression<Func<HybridStudy, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
