using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialShields
{
    public class SearchConfigurator : SearchableEntityConfigurator<PreciousMaterialShield>
    {
        public override Expression<Func<PreciousMaterialShield, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
