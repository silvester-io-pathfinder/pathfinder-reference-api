using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons
{
    public class SearchConfigurator : SearchableEntityConfigurator<MeleeWeapon>
    {
        public override Expression<Func<MeleeWeapon, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Damage, e.Description, e.Hands };
        }
    }
}
