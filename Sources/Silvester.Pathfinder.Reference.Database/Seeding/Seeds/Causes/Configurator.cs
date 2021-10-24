using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Causes
{
    public class SearchConfigurator : SearchableEntityConfigurator<Cause>
    {
        public override Expression<Func<Cause, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
