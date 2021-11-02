using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SenseAccuracies
{
    public class SearchConfigurator : SearchableEntityConfigurator<SenseAccuracy>
    {
        public override Expression<Func<SenseAccuracy, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
