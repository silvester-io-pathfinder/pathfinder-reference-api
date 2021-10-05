using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Stats
{
    public class SearchConfigurator : SearchableEntityConfigurator<Stat>
    {
        public override Expression<Func<Stat, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description, e.Abbreviation };
        }
    }
}
