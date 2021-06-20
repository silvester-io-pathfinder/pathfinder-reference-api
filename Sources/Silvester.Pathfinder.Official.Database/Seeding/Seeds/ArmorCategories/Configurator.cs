using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorCategories
{
    public class Configurator : SearchableEntityConfigurator<ArmorCategory>
    {
        public override Expression<Func<ArmorCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
