using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes
{
    public class SearchConfigurator : SearchableEntityConfigurator<WeaponPropertyRune>
    {
        public override Expression<Func<WeaponPropertyRune, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.AccessRequirements, e.CraftingRequirements, e.Usage };
        }
    }
}
