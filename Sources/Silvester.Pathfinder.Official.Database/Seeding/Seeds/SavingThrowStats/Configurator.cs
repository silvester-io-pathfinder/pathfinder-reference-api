using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

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
