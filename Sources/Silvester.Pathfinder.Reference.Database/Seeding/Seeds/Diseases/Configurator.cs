using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Diseases
{
    public class SearchConfigurator : SearchableEntityConfigurator<Disease>
    {
        public override Expression<Func<Disease, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description, e.Onset };
        }
    }
}
