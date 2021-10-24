using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MasterAbilities
{
    public class SearchConfigurator : SearchableEntityConfigurator<MasterAbility>
    {
        public override Expression<Func<MasterAbility, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
