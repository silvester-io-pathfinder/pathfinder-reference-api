using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources
{
    public class SearchConfigurator : SearchableEntityConfigurator<Source>
    {
        public override Expression<Func<Source, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
