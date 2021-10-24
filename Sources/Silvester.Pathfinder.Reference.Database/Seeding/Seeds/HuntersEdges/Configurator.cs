using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HuntersEdges
{
    public class SearchConfigurator : SearchableEntityConfigurator<HuntersEdge>
    {
        public override Expression<Func<HuntersEdge, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
