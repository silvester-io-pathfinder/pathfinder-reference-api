using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponCategories
{
    public class SearchConfigurator : SearchableEntityConfigurator<WeaponCategory>
    {
        public override Expression<Func<WeaponCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
