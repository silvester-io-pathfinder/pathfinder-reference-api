using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialItemCategories
{
    public class SearchConfigurator : SearchableEntityConfigurator<PreciousMaterialItemCategory>
    {
        public override Expression<Func<PreciousMaterialItemCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
