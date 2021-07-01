using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.LanguageTypes
{
    public class SearchConfigurator : SearchableEntityConfigurator<LanguageType>
    {
        public override Expression<Func<LanguageType, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
