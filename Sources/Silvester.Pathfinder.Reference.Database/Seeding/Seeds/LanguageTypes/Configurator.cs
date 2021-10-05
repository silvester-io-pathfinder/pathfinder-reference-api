using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.LanguageTypes
{
    public class SearchConfigurator : SearchableEntityConfigurator<LanguageType>
    {
        public override Expression<Func<LanguageType, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
