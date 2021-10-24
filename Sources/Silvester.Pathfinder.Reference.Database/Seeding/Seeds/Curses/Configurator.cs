using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Curses
{
    public class SearchConfigurator : SearchableEntityConfigurator<Curse>
    {
        public override Expression<Func<Curse, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Effect };
        }
    }
}
