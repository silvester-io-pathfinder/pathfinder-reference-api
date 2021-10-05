using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages
{
    public class SearchConfigurator : SearchableEntityConfigurator<Heritage>
    {
        public override Expression<Func<Heritage, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
