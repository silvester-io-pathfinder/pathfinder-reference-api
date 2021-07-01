using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains
{
    public class SearchConfigurator : SearchableEntityConfigurator<Domain>
    {
        public override Expression<Func<Domain, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
