using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Armors
{
    public class SearchConfigurator : SearchableEntityConfigurator<Armor>
    {
        public override Expression<Func<Armor, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
