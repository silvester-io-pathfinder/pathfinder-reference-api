using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FundamentalWeaponRunes
{
    public class SearchConfigurator : SearchableEntityConfigurator<FundamentalWeaponRune>
    {
        public override Expression<Func<FundamentalWeaponRune, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
