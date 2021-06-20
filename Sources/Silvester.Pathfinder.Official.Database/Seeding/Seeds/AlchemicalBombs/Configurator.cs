using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalBombs
{
    public class Configurator : SearchableEntityConfigurator<AlchemicalBomb>
    {
        public override Expression<Func<AlchemicalBomb, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Usage};
        }
    }
}
