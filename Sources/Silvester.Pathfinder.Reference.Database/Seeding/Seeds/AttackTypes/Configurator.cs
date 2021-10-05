using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AttackTypes
{
    public class SearchConfigurator : SearchableEntityConfigurator<AttackType>
    {
        public override Expression<Func<AttackType, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name};
        }
    }
}
