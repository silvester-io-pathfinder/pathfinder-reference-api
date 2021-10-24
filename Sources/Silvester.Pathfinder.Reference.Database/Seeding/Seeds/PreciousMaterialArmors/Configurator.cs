using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialArmors
{
    public class SearchConfigurator : SearchableEntityConfigurator<PreciousMaterialArmor>
    {
        public override Expression<Func<PreciousMaterialArmor, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
