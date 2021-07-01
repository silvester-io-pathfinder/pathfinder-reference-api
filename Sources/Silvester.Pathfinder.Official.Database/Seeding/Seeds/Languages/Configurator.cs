using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages
{
    public class SearchConfigurator : SearchableEntityConfigurator<Language>
    {
        public override Expression<Func<Language, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
