using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
