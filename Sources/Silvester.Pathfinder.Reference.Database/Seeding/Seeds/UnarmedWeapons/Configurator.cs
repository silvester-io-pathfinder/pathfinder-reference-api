using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.UnarmedWeapons
{
    public class SearchConfigurator : SearchableEntityConfigurator<UnarmedWeapon>
    {
        public override Expression<Func<UnarmedWeapon, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
