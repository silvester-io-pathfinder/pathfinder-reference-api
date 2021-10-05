using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Hazards
{
    public class SearchConfigurator : SearchableEntityConfigurator<Hazard>
    {
        public override Expression<Func<Hazard, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
