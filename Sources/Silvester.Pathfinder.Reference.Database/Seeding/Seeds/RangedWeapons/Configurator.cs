using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.RangedWeapons
{
    public class SearchConfigurator : SearchableEntityConfigurator<RangedWeapon>
    {
        public override Expression<Func<RangedWeapon, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Damage, e.Description };
        }
    }
}
