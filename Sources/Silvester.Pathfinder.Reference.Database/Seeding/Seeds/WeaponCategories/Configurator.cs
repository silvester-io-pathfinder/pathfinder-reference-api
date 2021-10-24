using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories
{
    public class SearchConfigurator : SearchableEntityConfigurator<WeaponCategory>
    {
        public override Expression<Func<WeaponCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
