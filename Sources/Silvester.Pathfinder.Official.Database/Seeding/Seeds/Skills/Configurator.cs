using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills
{
    public class SearchConfigurator : SearchableEntityConfigurator<Skill>
    {
        public override Expression<Func<Skill, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
