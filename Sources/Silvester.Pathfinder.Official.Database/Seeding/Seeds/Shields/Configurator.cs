using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Shields
{
    public class SearchConfigurator : SearchableEntityConfigurator<Shield>
    {
        public override Expression<Func<Shield, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
