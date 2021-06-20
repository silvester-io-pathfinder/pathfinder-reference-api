using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MeleeWeapons
{
    public class SearchConfigurator : SearchableEntityConfigurator<MeleeWeapon>
    {
        public override Expression<Func<MeleeWeapon, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Damage, e.Description, e.Hands };
        }
    }
}
