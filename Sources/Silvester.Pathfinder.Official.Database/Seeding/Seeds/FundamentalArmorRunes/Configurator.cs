using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.FundamentalArmorRunes
{
    public class SearchConfigurator : SearchableEntityConfigurator<FundamentalArmorRune>
    {
        public override Expression<Func<FundamentalArmorRune, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
