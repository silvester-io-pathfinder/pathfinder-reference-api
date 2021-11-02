using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Philosophies
{
    public class SearchConfigurator : SearchableEntityConfigurator<Philosophy>
    {
        public override Expression<Func<Philosophy, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Anathema, e.AreasOfConcern, e.Edicts };
        }
    }
}
