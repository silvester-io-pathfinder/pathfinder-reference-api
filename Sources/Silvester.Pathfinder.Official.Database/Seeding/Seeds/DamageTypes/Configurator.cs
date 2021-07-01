using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DamageTypes
{
    public class SearchConfigurator : SearchableEntityConfigurator<DamageType>
    {
        public override Expression<Func<DamageType, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
