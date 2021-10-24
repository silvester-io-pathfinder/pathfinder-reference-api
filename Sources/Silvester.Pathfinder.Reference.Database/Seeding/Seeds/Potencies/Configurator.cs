using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Potencies
{
    public class SearchConfigurator : SearchableEntityConfigurator<Potency>
    {
        public override Expression<Func<Potency, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
