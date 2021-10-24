using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Proficiencies
{
    public class SearchConfigurator : SearchableEntityConfigurator<Proficiency>
    {
        public override Expression<Func<Proficiency, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
