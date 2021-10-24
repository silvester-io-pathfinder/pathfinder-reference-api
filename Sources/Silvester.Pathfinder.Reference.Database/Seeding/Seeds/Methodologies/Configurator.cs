using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Methodologies
{
    public class SearchConfigurator : SearchableEntityConfigurator<Methodology>
    {
        public override Expression<Func<Methodology, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
