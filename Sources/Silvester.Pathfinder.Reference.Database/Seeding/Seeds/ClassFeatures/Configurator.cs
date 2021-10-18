using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures
{
    public class SearchConfigurator : SearchableEntityConfigurator<ClassFeature>
    {
        public override Expression<Func<ClassFeature, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
