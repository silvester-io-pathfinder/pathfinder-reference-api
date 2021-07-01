using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases
{
    public class SearchConfigurator : SearchableEntityConfigurator<Disease>
    {
        public override Expression<Func<Disease, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description, e.Onset };
        }
    }
}
