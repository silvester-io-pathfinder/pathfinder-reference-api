using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ResearchFields
{
    public class SearchConfigurator : SearchableEntityConfigurator<ResearchField>
    {
        public override Expression<Func<ResearchField, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
