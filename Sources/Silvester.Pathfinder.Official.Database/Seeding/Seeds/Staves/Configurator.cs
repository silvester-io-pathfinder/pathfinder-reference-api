using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves
{
    public class SearchConfigurator : SearchableEntityConfigurator<Stave>
    {
        public override Expression<Func<Stave, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Usage, e.CraftingRequirements, e.Activate };
        }
    }
}
