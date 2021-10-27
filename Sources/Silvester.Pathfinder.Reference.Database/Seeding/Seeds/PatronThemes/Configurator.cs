using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PatronThemes
{
    public class SearchConfigurator : SearchableEntityConfigurator<PatronTheme>
    {
        public override Expression<Func<PatronTheme, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
