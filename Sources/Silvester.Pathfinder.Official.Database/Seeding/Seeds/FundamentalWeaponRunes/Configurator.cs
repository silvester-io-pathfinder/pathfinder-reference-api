using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.FundamentalWeaponRunes
{
    public class SearchConfigurator : SearchableEntityConfigurator<FundamentalWeaponRune>
    {
        public override Expression<Func<FundamentalWeaponRune, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
