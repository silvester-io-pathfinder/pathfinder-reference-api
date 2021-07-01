using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits
{
    public class SearchConfigurator : SearchableEntityConfigurator<Trait>
    {
        public override Expression<Func<Trait, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
