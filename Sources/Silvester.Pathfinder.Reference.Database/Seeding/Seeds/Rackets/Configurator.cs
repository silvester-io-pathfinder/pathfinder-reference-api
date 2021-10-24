using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rackets
{
    public class SearchConfigurator : SearchableEntityConfigurator<Racket>
    {
        public override Expression<Func<Racket, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
