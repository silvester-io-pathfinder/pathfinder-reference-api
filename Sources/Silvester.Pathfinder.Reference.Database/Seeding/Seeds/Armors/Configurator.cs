using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Armors
{
    public class SearchConfigurator : SearchableEntityConfigurator<Armor>
    {
        public override Expression<Func<Armor, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
