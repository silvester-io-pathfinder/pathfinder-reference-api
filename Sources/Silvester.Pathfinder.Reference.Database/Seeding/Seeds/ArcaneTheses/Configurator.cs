using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArcaneTheses
{
    public class SearchConfigurator : SearchableEntityConfigurator<ArcaneThesis>
    {
        public override Expression<Func<ArcaneThesis, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
