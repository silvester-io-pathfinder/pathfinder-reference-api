using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups
{
    public class SearchConfigurator : SearchableEntityConfigurator<WeaponGroup>
    {
        public override Expression<Func<WeaponGroup, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.CriticalEffect };
        }
    }
}
