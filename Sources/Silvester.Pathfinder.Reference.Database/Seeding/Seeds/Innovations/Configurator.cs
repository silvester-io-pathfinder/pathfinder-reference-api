using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Innovations
{
    public class SearchConfigurator : SearchableEntityConfigurator<Innovation>
    {
        public override Expression<Func<Innovation, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name};
        }
    }
}
