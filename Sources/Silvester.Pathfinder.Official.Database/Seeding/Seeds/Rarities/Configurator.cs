using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Rarities
{
    public class SearchConfigurator : SearchableEntityConfigurator<Rarity>
    {
        public override Expression<Func<Rarity, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
