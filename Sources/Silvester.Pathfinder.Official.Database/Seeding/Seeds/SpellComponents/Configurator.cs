using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.SpellComponents
{
    public class SearchConfigurator : SearchableEntityConfigurator<SpellComponent>
    {
        public override Expression<Func<SpellComponent, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
