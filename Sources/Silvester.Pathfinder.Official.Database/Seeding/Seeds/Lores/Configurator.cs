using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores
{
    public class SearchConfigurator : SearchableEntityConfigurator<Lore>
    {
        public override Expression<Func<Lore, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
