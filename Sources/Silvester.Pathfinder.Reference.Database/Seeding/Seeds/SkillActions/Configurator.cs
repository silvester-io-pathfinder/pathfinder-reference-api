using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions
{
    public class SearchConfigurator : SearchableEntityConfigurator<SkillAction>
    {
        public override Expression<Func<SkillAction, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
