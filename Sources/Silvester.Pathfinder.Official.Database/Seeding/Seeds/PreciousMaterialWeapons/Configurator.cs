using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialWeapons
{
    public class SearchConfigurator : SearchableEntityConfigurator<PreciousMaterialWeapon>
    {
        public override Expression<Func<PreciousMaterialWeapon, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name  };
        }
    }
}
