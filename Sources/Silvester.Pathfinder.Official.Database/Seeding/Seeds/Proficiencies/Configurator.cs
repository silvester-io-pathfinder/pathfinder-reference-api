using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Proficiencies
{
    public class SearchConfigurator : SearchableEntityConfigurator<Proficiency>
    {
        public override Expression<Func<Proficiency, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
