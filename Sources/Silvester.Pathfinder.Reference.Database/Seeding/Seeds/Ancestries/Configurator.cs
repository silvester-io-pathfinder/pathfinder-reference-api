using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries
{
    public class SearchConfigurator : SearchableEntityConfigurator<Ancestry>
    {
        public override Expression<Func<Ancestry, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
