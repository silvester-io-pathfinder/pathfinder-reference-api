using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCurses
{
    public class SearchConfigurator : SearchableEntityConfigurator<ItemCurse>
    {
        public override Expression<Func<ItemCurse, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Usage };
        }
    }
}
