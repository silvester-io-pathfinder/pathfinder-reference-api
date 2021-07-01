using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DivineFonts
{
    public class SearchConfigurator : SearchableEntityConfigurator<DivineFont>
    {
        public override Expression<Func<DivineFont, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
