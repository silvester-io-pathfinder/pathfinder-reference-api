using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AncestrySizes
{
    public class SearchConfigurator : SearchableEntityConfigurator<AncestrySize>
    {
        public override Expression<Func<AncestrySize, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
