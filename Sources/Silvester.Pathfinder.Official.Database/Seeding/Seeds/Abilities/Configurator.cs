using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Abilities
{
    public class Configurator : SearchableEntityConfigurator<Ability>
    {
        public override Expression<Func<Ability, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}