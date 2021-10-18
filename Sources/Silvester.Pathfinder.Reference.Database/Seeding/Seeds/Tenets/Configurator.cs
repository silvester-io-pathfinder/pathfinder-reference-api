using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Tenets
{
    public class SearchConfigurator : SearchableEntityConfigurator<Tenet>
    {
        public override Expression<Func<Tenet, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
