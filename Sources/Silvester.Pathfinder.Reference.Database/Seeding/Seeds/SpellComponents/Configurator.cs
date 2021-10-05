using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SpellComponents
{
    public class SearchConfigurator : SearchableEntityConfigurator<SpellComponent>
    {
        public override Expression<Func<SpellComponent, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
