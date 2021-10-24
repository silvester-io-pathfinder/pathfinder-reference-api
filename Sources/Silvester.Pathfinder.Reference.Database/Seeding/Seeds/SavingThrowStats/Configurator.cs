using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SavingThrowStats
{
    public class SearchConfigurator : SearchableEntityConfigurator<SavingThrowStat>
    {
        public override Expression<Func<SavingThrowStat, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name  };
        }
    }
}
