using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.SavingThrowStats
{
    public class SearchConfigurator : SearchableEntityConfigurator<SavingThrowStat>
    {
        public override Expression<Func<SavingThrowStat, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name  };
        }
    }
}
