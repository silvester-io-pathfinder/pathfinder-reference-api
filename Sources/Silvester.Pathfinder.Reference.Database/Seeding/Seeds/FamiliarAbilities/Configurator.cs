using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities
{
    public class SearchConfigurator : SearchableEntityConfigurator<FamiliarAbility>
    {
        public override Expression<Func<FamiliarAbility, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
