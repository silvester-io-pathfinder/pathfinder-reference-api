using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Shields
{
    public class SearchConfigurator : SearchableEntityConfigurator<Shield>
    {
        public override Expression<Func<Shield, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
