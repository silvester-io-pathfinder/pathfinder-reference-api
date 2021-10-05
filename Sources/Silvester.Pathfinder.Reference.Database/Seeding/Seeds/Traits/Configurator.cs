using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits
{
    public class SearchConfigurator : SearchableEntityConfigurator<Trait>
    {
        public override Expression<Func<Trait, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
