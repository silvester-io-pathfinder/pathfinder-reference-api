using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs
{
    public class Configurator : SearchableEntityConfigurator<AlchemicalElixir>
    {
        public override Expression<Func<AlchemicalElixir, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Usage, e.Drawback, e.Benefit };
        }
    }
}
