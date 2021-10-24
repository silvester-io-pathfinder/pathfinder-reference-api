using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores
{
    public class SearchConfigurator : SearchableEntityConfigurator<Lore>
    {
        public override Expression<Func<Lore, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
