using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InstinctAbilities
{
    public class SearchConfigurator : SearchableEntityConfigurator<InstinctAbility>
    {
        public override Expression<Func<InstinctAbility, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
