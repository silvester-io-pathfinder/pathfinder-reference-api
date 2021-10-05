using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialWeapons
{
    public class SearchConfigurator : SearchableEntityConfigurator<PreciousMaterialWeapon>
    {
        public override Expression<Func<PreciousMaterialWeapon, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name  };
        }
    }
}
