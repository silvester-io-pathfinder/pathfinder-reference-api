using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Planes
{
    public class SearchConfigurator : SearchableEntityConfigurator<Plane>
    {
        public override Expression<Func<Plane, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
