using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes
{
    public class SearchConfigurator : SearchableEntityConfigurator<DamageType>
    {
        public override Expression<Func<DamageType, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
