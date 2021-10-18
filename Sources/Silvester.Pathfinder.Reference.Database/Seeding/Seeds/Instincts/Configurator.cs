using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Instincts
{
    public class SearchConfigurator : SearchableEntityConfigurator<Instinct>
    {
        public override Expression<Func<Instinct, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
